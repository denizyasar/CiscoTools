using System;

namespace CiscoTools
{
    public class AsaPasswordEncrypt : ICiscoCrypt
    {
        private readonly int _passlength;
        private readonly string _password;
        private readonly string _username;

        public AsaPasswordEncrypt(string username, string passwrod, int passLength)
        {
            _username = username;
            _passlength = passLength;
            _password = passwrod;
        }

        private string asa_md5(string s)
        {
            return asa_rstr2b64(rstr_md5(s));
        }

        private string asa_rstr2b64(string input)
        {
            const string tab = "./0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string output = string.Empty;
            int len = input.Length;

            for (int i = 0; i < len; i += 4)
            {
                int chunk32 = (input[i + 3] << 24
                               | input[i + 2] << 16
                               | input[i + 1] << 8
                               | input[i]);

                for (int j = 0; j < 4; j++)
                    output += tab[(int)((uint)chunk32 >> (6 * j)) & 0x3F];
            }
            return output;
        }

        private int[] binl_md5(int[] t, int k)
        {
            var p = new int[50];
            Array.Copy(t, p, t.Length);

            p[k >> 5] |= 128 << (k % 32);
            p[((int)((uint)(k + 64) >> 9) << 4) + 14] = k;

            int o = 1732584193;
            int n = -271733879;
            int m = -1732584194;
            int l = 271733878;

            for (int g = 0; g < t.Length; g += 16)
            {
                int j = o;
                int h = n;
                int f = m;
                int e = l;
                o = md5_ff(o, n, m, l, p[g + 0], 7, -680876936);
                l = md5_ff(l, o, n, m, p[g + 1], 12, -389564586);
                m = md5_ff(m, l, o, n, p[g + 2], 17, 606105819);
                n = md5_ff(n, m, l, o, p[g + 3], 22, -1044525330);
                o = md5_ff(o, n, m, l, p[g + 4], 7, -176418897);
                l = md5_ff(l, o, n, m, p[g + 5], 12, 1200080426);
                m = md5_ff(m, l, o, n, p[g + 6], 17, -1473231341);
                n = md5_ff(n, m, l, o, p[g + 7], 22, -45705983);
                o = md5_ff(o, n, m, l, p[g + 8], 7, 1770035416);
                l = md5_ff(l, o, n, m, p[g + 9], 12, -1958414417);
                m = md5_ff(m, l, o, n, p[g + 10], 17, -42063);
                n = md5_ff(n, m, l, o, p[g + 11], 22, -1990404162);
                o = md5_ff(o, n, m, l, p[g + 12], 7, 1804603682);
                l = md5_ff(l, o, n, m, p[g + 13], 12, -40341101);
                m = md5_ff(m, l, o, n, p[g + 14], 17, -1502002290);
                n = md5_ff(n, m, l, o, p[g + 15], 22, 1236535329);
                o = md5_gg(o, n, m, l, p[g + 1], 5, -165796510);
                l = md5_gg(l, o, n, m, p[g + 6], 9, -1069501632);
                m = md5_gg(m, l, o, n, p[g + 11], 14, 643717713);
                n = md5_gg(n, m, l, o, p[g + 0], 20, -373897302);
                o = md5_gg(o, n, m, l, p[g + 5], 5, -701558691);
                l = md5_gg(l, o, n, m, p[g + 10], 9, 38016083);
                m = md5_gg(m, l, o, n, p[g + 15], 14, -660478335);
                n = md5_gg(n, m, l, o, p[g + 4], 20, -405537848);
                o = md5_gg(o, n, m, l, p[g + 9], 5, 568446438);
                l = md5_gg(l, o, n, m, p[g + 14], 9, -1019803690);
                m = md5_gg(m, l, o, n, p[g + 3], 14, -187363961);
                n = md5_gg(n, m, l, o, p[g + 8], 20, 1163531501);
                o = md5_gg(o, n, m, l, p[g + 13], 5, -1444681467);
                l = md5_gg(l, o, n, m, p[g + 2], 9, -51403784);
                m = md5_gg(m, l, o, n, p[g + 7], 14, 1735328473);
                n = md5_gg(n, m, l, o, p[g + 12], 20, -1926607734);
                o = md5_hh(o, n, m, l, p[g + 5], 4, -378558);
                l = md5_hh(l, o, n, m, p[g + 8], 11, -2022574463);
                m = md5_hh(m, l, o, n, p[g + 11], 16, 1839030562);
                n = md5_hh(n, m, l, o, p[g + 14], 23, -35309556);
                o = md5_hh(o, n, m, l, p[g + 1], 4, -1530992060);
                l = md5_hh(l, o, n, m, p[g + 4], 11, 1272893353);
                m = md5_hh(m, l, o, n, p[g + 7], 16, -155497632);
                n = md5_hh(n, m, l, o, p[g + 10], 23, -1094730640);
                o = md5_hh(o, n, m, l, p[g + 13], 4, 681279174);
                l = md5_hh(l, o, n, m, p[g + 0], 11, -358537222);
                m = md5_hh(m, l, o, n, p[g + 3], 16, -722521979);
                n = md5_hh(n, m, l, o, p[g + 6], 23, 76029189);
                o = md5_hh(o, n, m, l, p[g + 9], 4, -640364487);
                l = md5_hh(l, o, n, m, p[g + 12], 11, -421815835);
                m = md5_hh(m, l, o, n, p[g + 15], 16, 530742520);
                n = md5_hh(n, m, l, o, p[g + 2], 23, -995338651);
                o = md5_ii(o, n, m, l, p[g + 0], 6, -198630844);
                l = md5_ii(l, o, n, m, p[g + 7], 10, 1126891415);
                m = md5_ii(m, l, o, n, p[g + 14], 15, -1416354905);
                n = md5_ii(n, m, l, o, p[g + 5], 21, -57434055);
                o = md5_ii(o, n, m, l, p[g + 12], 6, 1700485571);
                l = md5_ii(l, o, n, m, p[g + 3], 10, -1894986606);
                m = md5_ii(m, l, o, n, p[g + 10], 15, -1051523);
                n = md5_ii(n, m, l, o, p[g + 1], 21, -2054922799);
                o = md5_ii(o, n, m, l, p[g + 8], 6, 1873313359);
                l = md5_ii(l, o, n, m, p[g + 15], 10, -30611744);
                m = md5_ii(m, l, o, n, p[g + 6], 15, -1560198380);
                n = md5_ii(n, m, l, o, p[g + 13], 21, 1309151649);
                o = md5_ii(o, n, m, l, p[g + 4], 6, -145523070);
                l = md5_ii(l, o, n, m, p[g + 11], 10, -1120210379);
                m = md5_ii(m, l, o, n, p[g + 2], 15, 718787259);
                n = md5_ii(n, m, l, o, p[g + 9], 21, -343485551);
                o = safe_add(o, j);
                n = safe_add(n, h);
                m = safe_add(m, f);
                l = safe_add(l, e);
            }
            return new[] { o, n, m, l };
        }

        private string binl2rstr(int[] b)
        {
            string a = string.Empty;
            for (int c = 0; c < b.Length * 32; c += 8)
                a += (char)((int)((uint)b[c >> 5] >> (c % 32)) & 255);

            return a;
        }

        private int bit_rol(int a, int b)
        {
            return ((a << b) | (int)((uint)a >> (32 - b)));
        }

        private int md5_cmn(int h, int e, int d, int c, int g, int f)
        {
            return safe_add(bit_rol(safe_add(safe_add(e, h), safe_add(c, f)), g), d);
        }

        private int md5_ff(int g, int f, int k, int j, int e, int i, int h)
        {
            return md5_cmn((f & k) | ((~f) & j), g, f, e, i, h);
        }

        private int md5_gg(int g, int f, int k, int j, int e, int i, int h)
        {
            return md5_cmn((f & j) | (k & (~j)), g, f, e, i, h);
        }

        private int md5_hh(int g, int f, int k, int j, int e, int i, int h)
        {
            return md5_cmn(f ^ k ^ j, g, f, e, i, h);
        }

        private int md5_ii(int g, int f, int k, int j, int e, int i, int h)
        {
            return md5_cmn(k ^ (f | (~j)), g, f, e, i, h);
        }

        private string rightPad(string s, int len)
        {
            return $"{s}{(string.Join("\0", new string[len - s.Length + 1]))}";
        }

        private string rstr_md5(string a)
        {
            return binl2rstr(binl_md5(rstr2binl(a), a.Length * 8));
        }

        private int[] rstr2binl(string b)
        {
            var a = new int[b.Length >> 2];
            for (int c = 0; c < a.Length; c++)
                a[c] = 0;

            for (int c = 0; c < b.Length * 8; c += 8)
                a[c >> 5] |= (b[c / 8] & 255) << (c % 32);

            return a;
        }

        private int safe_add(int a, int d)
        {
            int c = (a & 65535) + (d & 65535);
            int b = (a >> 16) + (d >> 16) + (c >> 16);
            return (b << 16) | (c & 65535);
        }

        private string saltPassword(string username, string password, int saltLength)
        {
            return $"{password}{(username.Substring(0, saltLength))}";
        }

        private string truncate(string s, int len)
        {
            if (len > s.Length)
                len = s.Length;
            return s.Trim().Substring(0, len);
        }

        public string Decrypt()
        {
            throw new NotImplementedException();
        }

        public string Encrypt()
        {
            int saltLength;
            int padLen;
            int truncLen;

            int passwordLength = _password.Length;

            if (_passlength == 16 && passwordLength > 2 && passwordLength <= 16)
            {
                padLen = 16;
                truncLen = 16;
                saltLength = 4;
            }
            else if (passwordLength > 2 && (passwordLength <= 12))
            {
                padLen = 16;
                truncLen = 16;
                saltLength = 4;
            }
            else if (passwordLength > 12 && (passwordLength < _passlength - 4))
            {
                padLen = 32;
                truncLen = 32;
                saltLength = 4;
            }
            else if ((passwordLength >= _passlength - 4) && (passwordLength <= _passlength))
            {
                padLen = 32;
                truncLen = 32;
                saltLength = 0;
            }
            else
                return $"Passwords must be between 3 and {_passlength} characters";
            // limits seen through trial on ASA 8.2(3)
            if (_username == string.Empty)
                return "Enter a username";

            string sp = saltPassword(_username, _password, saltLength);


            return asa_md5(rightPad(truncate(sp, truncLen), padLen));
        }
    }
}