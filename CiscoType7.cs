using System;
using System.Text;

namespace CiscoTools
{
    public class CiscoType7 : ICiscoCrypt
    {
        private readonly byte[] _ab2 =
        {
            100, 115, 102, 100, 59, 107, 102, 111, 65, 44, 46, 105, 121, 101, 119, 114, 107, 108, 100, 74,
            75, 68, 72, 83, 85, 66
        };

        private readonly string _phrase;

        public CiscoType7(string phrase)
        {
            _phrase = phrase;
        }

        private string ByteArrayToString(byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.Append($"{b:x2}");
            string strValue = string.Empty;
            while (hex.Length > 0)
            {
                // Use ToChar() to convert each ASCII value (two hex digits) to the actual character
                strValue += Convert.ToChar(Convert.ToUInt32(hex.ToString().Substring(0, 2), 16)).ToString();
                // Remove from the hex object the converted value
                hex.Remove(0, 2);
            }
            return strValue;
        }

        public string Decrypt()
        {
            byte[] ab1;
            int i1 = _phrase.Length;
            try
            {
                int j = Convert.ToInt32(_phrase[0].ToString(), 10) * 10 + Convert.ToInt32(_phrase[1].ToString(), 10);
                ab1 = new byte[(i1 - 2) / 2];
                for (int k = 2; k < i1; k += 2)
                {
                    int i2 = Convert.ToInt32(_phrase[k].ToString(), 16) * 16 +
                             Convert.ToInt32(_phrase[k + 1].ToString(), 16);
                    ab1[k / 2 - 1] = (byte)(i2 ^ _ab2[j++]);
                }
            }
            catch (Exception)
            {
                return "Invalid Encrypted Password !!!";
            }
            return ByteArrayToString(ab1);
        }

        public string Encrypt()
        {
            int n = 2;
            string result = "02";

            try
            {
                for (int i = 0; i < _phrase.Length; i += 1)
                {
                    int tmp = int.Parse(Encoding.ASCII.GetBytes(_phrase.Substring(i, 1))[0].ToString()) ^ _ab2[n++];
                    result += $"{tmp:X2}";
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
            return result;
        }
    }
}