using System;

namespace CiscoTools.IPAddressControl
{
    public class FieldChangedEventArgs : EventArgs
    {
        public int FieldIndex { get; set; }

        public string Text { get; set; }
    }
}