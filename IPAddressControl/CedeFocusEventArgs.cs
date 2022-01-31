using System;

namespace CiscoTools.IPAddressControl
{
    internal class CedeFocusEventArgs : EventArgs
    {
        public Action Action { get; set; }

        public Direction Direction { get; set; }

        public int FieldIndex { get; set; }

        public Selection Selection { get; set; }
    }
}