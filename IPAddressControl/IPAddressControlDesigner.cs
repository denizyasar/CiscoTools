using System.Collections;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace CiscoTools.IPAddressControl
{
    internal class IPAddressControlDesigner : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                if (((IPAddressControlLib.IPAddressControl)Control).AutoHeight)
                {
                    return SelectionRules.Moveable | SelectionRules.Visible | SelectionRules.LeftSizeable |
                           SelectionRules.RightSizeable;
                }
                return SelectionRules.Moveable | SelectionRules.Visible | SelectionRules.TopSizeable |
                       SelectionRules.BottomSizeable | SelectionRules.LeftSizeable | SelectionRules.RightSizeable |
                       SelectionRules.AllSizeable;
            }
        }

        public override IList SnapLines
        {
            get
            {
                var control = (IPAddressControlLib.IPAddressControl)Control;
                IList snapLines = base.SnapLines;
                snapLines.Add(new SnapLine(SnapLineType.Baseline, control.Baseline));
                return snapLines;
            }
        }
    }
}