using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CiscoTools
{
    internal class VpnGroupPasswordDecrypter : ICiscoCrypt
    {
        private readonly string _password;

        public VpnGroupPasswordDecrypter(string password)
        {
            _password = password.Replace(" ", string.Empty);
        }

        private byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public String Decrypt()
        {
            byte[] ciphertextBytes;

            try
            {
                ciphertextBytes = StringToByteArray(_password);
            }
            catch (Exception)
            {
                return "Invalid Encrypted Group Password";
            }

            if (ciphertextBytes.Length < 48)
                return "Invalid Encrypted Group Password";

            var iv = new byte[8];
            Array.Copy(ciphertextBytes, 0, iv, 0, 8);
            var ht = new byte[20];
            Array.Copy(ciphertextBytes, 0, ht, 0, 20);
            ht[19]++;
            var h4 = new byte[20];
            Array.Copy(ciphertextBytes, 20, h4, 0, 20);

            SHA1 sha1 = SHA1.Create();
            byte[] h2 = sha1.ComputeHash(ht);
            ht[19] += 2;
            byte[] h3 = sha1.ComputeHash(ht);
            var key = new byte[24];
            Array.Copy(h2, 0, key, 0, 20);
            Array.Copy(h3, 0, key, 20, 4);
            var ciphertextBytesWithoutHeader = new byte[ciphertextBytes.Length - 40];
            Array.Copy(ciphertextBytes, 40, ciphertextBytesWithoutHeader, 0, ciphertextBytesWithoutHeader.Length);
            ht = sha1.ComputeHash(ciphertextBytesWithoutHeader);

            if (!h4.SequenceEqual(ht))
                return "Invalid Encrypted Group Password";

            var tds = new TripleDESCryptoServiceProvider
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                IV = iv,
                Key = key
            };

            try
            {
                return
                    Encoding.UTF8.GetString(tds.CreateDecryptor()
                        .TransformFinalBlock(ciphertextBytesWithoutHeader, 0, ciphertextBytesWithoutHeader.Length));
            }
            catch (Exception)
            {
                return "Invalid Encrypted Group Password";
            }
        }


        public string Encrypt()
        {
            throw new NotImplementedException();
        }
    }
}