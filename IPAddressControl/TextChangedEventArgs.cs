using System;

namespace CiscoTools.IPAddressControl
{
    internal class TextChangedEventArgs : EventArgs
    {
        public int FieldIndex { get; set; }

        public string Text { get; set; }
    }
}