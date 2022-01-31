using CiscoTools.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CiscoTools.IPAddressControl
{
    internal sealed class FieldControl : TextBox
    {

        private const TextFormatFlags TextFormatFlags =
            System.Windows.Forms.TextFormatFlags.HorizontalCenter | System.Windows.Forms.TextFormatFlags.SingleLine |
            System.Windows.Forms.TextFormatFlags.NoPadding;

        public const byte MaximumValue = 255;
        public const byte MinimumValue = 0;

        private int _fieldIndex = -1;

        private byte _rangeLower;

        private byte _rangeUpper = 255;

        public FieldControl()
        {
            BorderStyle = BorderStyle.None;
            MaxLength = 3;
            Size = MinimumSize;
            TabStop = false;
            TextAlign = HorizontalAlignment.Center;
        }

        public event EventHandler<CedeFocusEventArgs> CedeFocusEvent;

        public event EventHandler<TextChangedEventArgs> TextChangedEvent;

        private void HandleBackspaceKey(KeyEventArgs e)
        {
            if (!ReadOnly && (TextLength == 0 || SelectionStart == 0 && SelectionLength == 0))
            {
                SendCedeFocusEvent(Action.Trim);
                e.SuppressKeyPress = true;
            }
        }

        private static bool IsBackspaceKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                return true;
            }
            return false;
        }

        private bool IsCedeFocusKey(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.OemPeriod && e.KeyCode != Keys.Decimal && e.KeyCode != Keys.Space || TextLength == 0 ||
                SelectionLength != 0 || SelectionStart == 0)
            {
                return false;
            }
            return true;
        }

        private static bool IsEditKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                return true;
            }
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                return true;
            }
            return false;
        }

        private static bool IsEnterKey(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Return)
            {
                return false;
            }
            return true;
        }

        private static bool IsForwardKey(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Down)
            {
                return false;
            }
            return true;
        }

        private static bool IsNumericKey(KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                return true;
            }
            return false;
        }

        private static bool IsReverseKey(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Up)
            {
                return false;
            }
            return true;
        }

        private void SendCedeFocusEvent(Action action)
        {
            if (CedeFocusEvent != null)
            {
                var cedeFocusEventArg = new CedeFocusEventArgs
                {
                    FieldIndex = FieldIndex,
                    Action = action
                };
                CedeFocusEvent(this, cedeFocusEventArg);
            }
        }

        private void SendCedeFocusEvent(Direction direction, Selection selection)
        {
            if (CedeFocusEvent != null)
            {
                var cedeFocusEventArg = new CedeFocusEventArgs
                {
                    FieldIndex = FieldIndex,
                    Action = Action.None,
                    Direction = direction,
                    Selection = selection
                };
                CedeFocusEvent(this, cedeFocusEventArg);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e");
            }
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.End:
                    {
                        SendCedeFocusEvent(Action.End);
                        return;
                    }
                case Keys.Home:
                    {
                        SendCedeFocusEvent(Action.Home);
                        return;
                    }
            }
            if (IsCedeFocusKey(e))
            {
                SendCedeFocusEvent(Direction.Forward, Selection.All);
                e.SuppressKeyPress = true;
                return;
            }
            if (IsForwardKey(e))
            {
                if (e.Control)
                {
                    SendCedeFocusEvent(Direction.Forward, Selection.All);
                    return;
                }
                if (SelectionLength == 0 && SelectionStart == TextLength)
                {
                    SendCedeFocusEvent(Direction.Forward, Selection.None);
                }
            }
            else if (!IsReverseKey(e))
            {
                if (IsBackspaceKey(e))
                {
                    HandleBackspaceKey(e);
                    return;
                }
                if (!IsNumericKey(e) && !IsEditKey(e) && !IsEnterKey(e))
                {
                    e.SuppressKeyPress = true;
                }
            }
            else
            {
                if (e.Control)
                {
                    SendCedeFocusEvent(Direction.Reverse, Selection.All);
                    return;
                }
                if (SelectionLength == 0 && SelectionStart == 0)
                {
                    SendCedeFocusEvent(Direction.Reverse, Selection.None);
                }
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            BackColor = Parent.BackColor;
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
            ForeColor = Parent.ForeColor;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Size = MinimumSize;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!Blank)
            {
                int num;
                if (!int.TryParse(Text, out num))
                {
                    base.Text = string.Empty;
                }
                else if (num > RangeUpper)
                {
                    base.Text = RangeUpper.ToString(CultureInfo.InvariantCulture);
                    SelectionStart = 0;
                }
                else if (TextLength != MaxLength || num >= RangeLower)
                {
                    int textLength = TextLength;
                    int selectionStart = SelectionStart;
                    base.Text = num.ToString(CultureInfo.InvariantCulture);
                    if (TextLength < textLength)
                    {
                        selectionStart = selectionStart - (textLength - TextLength);
                        SelectionStart = Math.Max(0, selectionStart);
                    }
                }
                else
                {
                    base.Text = RangeLower.ToString(CultureInfo.InvariantCulture);
                    SelectionStart = 0;
                }
            }
            if (TextChangedEvent != null)
            {
                var textChangedEventArg = new TextChangedEventArgs
                {
                    FieldIndex = FieldIndex,
                    Text = Text
                };
                TextChangedEvent(this, textChangedEventArg);
            }
            if (TextLength == MaxLength && Focused && SelectionStart == TextLength)
            {
                SendCedeFocusEvent(Direction.Forward, Selection.All);
            }
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            if (!Blank && Value < RangeLower)
            {
                Text = RangeLower.ToString(CultureInfo.InvariantCulture);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 123)
            {
                return;
            }
            base.WndProc(ref m);
        }

        public void TakeFocus(Action action)
        {
            Focus();
            switch (action)
            {
                case Action.Trim:
                    {
                        if (TextLength > 0)
                        {
                            int textLength = TextLength - 1;
                            base.Text = Text.Substring(0, textLength);
                        }
                        SelectionStart = TextLength;
                        return;
                    }
                case Action.Home:
                    {
                        SelectionStart = 0;
                        SelectionLength = 0;
                        return;
                    }
                case Action.End:
                    {
                        SelectionStart = TextLength;
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        public void TakeFocus(Direction direction, Selection selection)
        {
            Focus();
            if (selection == Selection.All)
            {
                SelectionStart = 0;
                SelectionLength = TextLength;
                return;
            }
            SelectionStart = (direction == Direction.Forward ? 0 : TextLength);
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }

        public bool Blank
        {
            get { return TextLength == 0; }
        }

        public int FieldIndex
        {
            get { return _fieldIndex; }
            set { _fieldIndex = value; }
        }

        public override Size MinimumSize
        {
            get
            {
                Graphics graphic = Graphics.FromHwnd(Handle);
                Size size = TextRenderer.MeasureText(graphic, Resources.FieldMeasureText, Font, Size, TextFormatFlags);
                graphic.Dispose();
                return size;
            }
        }

        public byte RangeLower
        {
            get { return _rangeLower; }
            set
            {
                if (value <= _rangeUpper)
                {
                    _rangeLower = value;
                }
                else
                {
                    _rangeLower = _rangeUpper;
                }
                if (Value < _rangeLower)
                {
                    Text = _rangeLower.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        public byte RangeUpper
        {
            get { return _rangeUpper; }
            set
            {
                if (value < _rangeLower)
                {
                    _rangeUpper = _rangeLower;
                }
                else if (value <= 255)
                {
                    _rangeUpper = value;
                }
                else
                {
                    _rangeUpper = 255;
                }
                if (Value > _rangeUpper)
                {
                    Text = _rangeUpper.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        public byte Value
        {
            get
            {
                byte rangeLower;
                if (!byte.TryParse(Text, out rangeLower))
                {
                    rangeLower = RangeLower;
                }
                return rangeLower;
            }
        }
    }
}