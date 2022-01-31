using System;
using System.Runtime.InteropServices;

namespace CiscoTools.IPAddressControl
{
    internal class NativeMethods
    {
        private NativeMethods()
        {
        }

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern bool DeleteObject(IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern bool GetTextMetrics(IntPtr hdc, out TEXTMETRIC lptm);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [Serializable]
        public struct TEXTMETRIC
        {
            public int tmAscent;

            public int tmAveCharWidth;
            public char tmBreakChar;
            public byte tmCharSet;
            public char tmDefaultChar;
            public int tmDescent;

            public int tmDigitizedAspectX;

            public int tmDigitizedAspectY;
            public int tmExternalLeading;

            public char tmFirstChar;
            public int tmHeight;
            public int tmInternalLeading;

            public byte tmItalic;
            public char tmLastChar;
            public int tmMaxCharWidth;
            public int tmOverhang;

            public byte tmPitchAndFamily;
            public byte tmStruckOut;
            public byte tmUnderlined;
            public int tmWeight;
        }
    }
}