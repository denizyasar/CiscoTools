using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace CiscoTools
{
    public class IouGen
    {
        private const string Info1 = "Add the following text to ~/.iourc:\n[license]\n";

        private const string Info2 =
            ";\n\nYou can disable the phone home feature with something like:\necho '127.0.0.127 xml.cisco.com' >> /etc/hosts";

        private readonly string _hostId;
        private readonly string _hostname;

        private readonly byte[] _iouPad1 =
        {
            0x4B, 0x58, 0x21, 0x81, 0x56, 0x7B, 0x0D, 0xF3, 0x21, 0x43, 0x9B, 0x7E, 0xAC, 0x1D,
            0xE6, 0x8A
        };

        private readonly byte[] _iouPad2 =
        {
            0x80, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0
        };

        public IouGen(string hostname, string hostId)
        {
            _hostname = hostname;
            _hostId = hostId;
        }

        private void CopyBytes(long value, int bytes, byte[] buffer, int index)
        {
            int endOffset = index + bytes - 1;
            for (int i = 0; i < bytes; i++)
            {
                buffer[endOffset - i] = unchecked((byte)(value & 0xff));
                value = value >> 8;
            }
        }

        private IEnumerable<byte> GetBytes(long value, int bytes)
        {
            var buffer = new byte[bytes];
            CopyBytes(value, bytes, buffer, 0);
            return buffer;
        }

        private string Md5Sum(byte[] strToEncrypt)
        {
            byte[] bytes = strToEncrypt;

            // encrypt bytes
            var md5 =
                new MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)
            string hashString = hashBytes.Aggregate(string.Empty,
                (current, t) => $"{current}{(Convert.ToString(t, 16).PadLeft(2, '0'))}");

            return hashString.PadLeft(32, '0');
        }

        public long IouKey()
        {
            try
            {
                int ioukey = Int32.Parse(_hostId, NumberStyles.HexNumber);
                return _hostname.Aggregate(ioukey, (current, _char) => current + _char);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string License()
        {
            byte[] combined = _iouPad1.Concat(_iouPad2).Concat(GetBytes(IouKey(), 4)).Concat(_iouPad1).ToArray();
            string s = Md5Sum(combined);

            return $"{Info1}{_hostname}={s.Substring(0, 16)}{Info2}";
        }
    }
}