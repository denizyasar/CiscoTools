using System;
using System.Security.Cryptography;
using System.Text;

namespace CiscoTools
{
    public class PixActivation
    {
        private readonly string _serial;

        public PixActivation(string serial)
        {
            _serial = serial;
        }

        private byte[] Pack(string hex)
        {
            if ((hex.Length % 2) == 1) hex += '0';
            var bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private string PrintMd5Hex(byte[] data)
        {
            var md5 = new MD5CryptoServiceProvider();
            var dataHash = md5.ComputeHash(data);
            var sb = new StringBuilder();
            foreach (var b in dataHash)
                sb.Append(b.ToString("x2").ToLower());

            return sb.ToString();
        }

        public string Activate()
        {
            string result = string.Empty;
            try
            {
                var s = $"{int.Parse(_serial):X}";
                var s1 = $"{(s.Substring(6, 2))}{(s.Substring(4, 2))}{(s.Substring(2, 2))}{(s.Substring(0, 2))}";
                var s2 = $"39000000{s1.ToLower()}";
                var s3 = PrintMd5Hex(Pack(s2));
                for (int i = 6; i <= 30; i += 8)
                    result += $@"0x{(s3.Substring(i, 2))}{(s3.Substring(i - 2, 2))}{(s3.Substring(i - 4, 2))}{(s3.Substring(i - 6, 2))} ";
                return result.Remove(result.Length - 1, 1);
            }
            catch
            {
                return "Invalid Serial Number !!!";
            }
        }
    }
}