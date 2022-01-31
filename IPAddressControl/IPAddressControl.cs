using CiscoTools.IPAddressControl;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Action = CiscoTools.IPAddressControl.Action;

namespace IPAddressControlLib
{
    [Designer(typeof(IPAddressControlDesigner))]
    public class IPAddressControl : ContainerControl
    {
        public const int FieldCount = 4;

        private bool _autoHeight = true;

        private bool _backColorChanged;

        private BorderStyle _borderStyle;

        private DotControl[] _dotControls = new DotControl[3];

        private FieldControl[] _fieldControls = new FieldControl[4];

        private bool _focused;

        private bool _hasMouse;

        private bool _readOnly;
        private readonly TextBox _referenceTextBox = new TextBox();

        private Size Fixed3DOffset = new Size(3, 3);

        private Size FixedSingleOffset = new Size(2, 2);

        public IPAddressControl()
        {
            BackColor = SystemColors.Window;
            ResetBackColorChanged();
            for (int i = 0; i < _fieldControls.Length; i++)
            {
                _fieldControls[i] = new FieldControl();
                _fieldControls[i].CreateControl();
                _fieldControls[i].FieldIndex = i;
                _fieldControls[i].Name = string.Concat("FieldControl", i.ToString(CultureInfo.InvariantCulture));
                _fieldControls[i].Parent = this;
                _fieldControls[i].CedeFocusEvent += OnCedeFocus;
                _fieldControls[i].Click += OnSubControlClicked;
                _fieldControls[i].DoubleClick += OnSubControlDoubleClicked;
                _fieldControls[i].GotFocus += OnFieldGotFocus;
                _fieldControls[i].KeyDown += OnFieldKeyDown;
                _fieldControls[i].KeyPress += OnFieldKeyPressed;
                _fieldControls[i].KeyUp += OnFieldKeyUp;
                _fieldControls[i].LostFocus += OnFieldLostFocus;
                _fieldControls[i].MouseClick += OnSubControlMouseClicked;
                _fieldControls[i].MouseDoubleClick += OnSubControlMouseDoubleClicked;
                _fieldControls[i].MouseEnter += OnSubControlMouseEntered;
                _fieldControls[i].MouseHover += OnSubControlMouseHovered;
                _fieldControls[i].MouseLeave += OnSubControlMouseLeft;
                _fieldControls[i].MouseMove += OnSubControlMouseMoved;
                _fieldControls[i].PreviewKeyDown += OnFieldPreviewKeyDown;
                _fieldControls[i].TextChangedEvent += OnFieldTextChanged;
                base.Controls.Add(_fieldControls[i]);
                if (i < 3)
                {
                    _dotControls[i] = new DotControl();
                    _dotControls[i].CreateControl();
                    _dotControls[i].Name = string.Concat("DotControl", i.ToString(CultureInfo.InvariantCulture));
                    _dotControls[i].Parent = this;
                    _dotControls[i].Click += OnSubControlClicked;
                    _dotControls[i].DoubleClick += OnSubControlDoubleClicked;
                    _dotControls[i].MouseClick += OnSubControlMouseClicked;
                    _dotControls[i].MouseDoubleClick += OnSubControlMouseDoubleClicked;
                    _dotControls[i].MouseEnter += OnSubControlMouseEntered;
                    _dotControls[i].MouseHover += OnSubControlMouseHovered;
                    _dotControls[i].MouseLeave += OnSubControlMouseLeft;
                    _dotControls[i].MouseMove += OnSubControlMouseMoved;
                    base.Controls.Add(_dotControls[i]);
                }
            }
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.FixedWidth, true);
            base.SetStyle(ControlStyles.FixedHeight, true);
            _referenceTextBox.AutoSize = true;
            Cursor = Cursors.IBeam;
            base.AutoScaleDimensions = new SizeF(96f, 96f);
            base.AutoScaleMode = AutoScaleMode.Dpi;
            base.Size = MinimumSize;
            base.DragEnter += IPAddressControl_DragEnter;
            base.DragDrop += IPAddressControl_DragDrop;
        }

        public event EventHandler<FieldChangedEventArgs> FieldChangedEvent;

        private void AdjustSize()
        {
            Size minimumSize = MinimumSize;
            if (base.Width > minimumSize.Width)
            {
                minimumSize.Width = base.Width;
            }
            if (base.Height > minimumSize.Height)
            {
                minimumSize.Height = base.Height;
            }
            if (!AutoHeight)
            {
                base.Size = minimumSize;
            }
            else
            {
                base.Size = new Size(minimumSize.Width, MinimumSize.Height);
            }
            LayoutControls();
        }

        private Size CalculateMinimumSize()
        {
            var size = new Size(0, 0);
            FieldControl[] fieldControlArray = _fieldControls;
            foreach (FieldControl fieldControl in fieldControlArray)
            {
                size.Width = size.Width + fieldControl.Width;
                size.Height = Math.Max(size.Height, fieldControl.Height);
            }
            DotControl[] dotControlArray = _dotControls;
            foreach (DotControl dotControl in dotControlArray)
            {
                size.Width = size.Width + dotControl.Width;
                size.Height = Math.Max(size.Height, dotControl.Height);
            }
            switch (BorderStyle)
            {
                case BorderStyle.FixedSingle:
                    {
                        size.Width = size.Width + 4;
                        size.Height = size.Height + (GetSuggestedHeight() - size.Height);
                        break;
                    }
                case BorderStyle.Fixed3D:
                    {
                        size.Width = size.Width + 6;
                        size.Height = size.Height + (GetSuggestedHeight() - size.Height);
                        break;
                    }
            }
            return size;
        }

        private void Cleanup()
        {
            DotControl[] dotControlArray = _dotControls;
            for (int i = 0; i < dotControlArray.Length; i++)
            {
                DotControl dotControl = dotControlArray[i];
                base.Controls.Remove(dotControl);
                dotControl.Dispose();
            }
            FieldControl[] fieldControlArray = _fieldControls;
            for (int j = 0; j < fieldControlArray.Length; j++)
            {
                FieldControl fieldControl = fieldControlArray[j];
                base.Controls.Remove(fieldControl);
                fieldControl.Dispose();
            }
            _dotControls = null;
            _fieldControls = null;
        }

        private int GetSuggestedHeight()
        {
            _referenceTextBox.BorderStyle = BorderStyle;
            _referenceTextBox.Font = Font;
            return _referenceTextBox.Height;
        }

        [SuppressMessage("Microsoft.Usage", "CA1806", Justification = "What should be done if ReleaseDC() doesn't work?"
            )]
        private static NativeMethods.TEXTMETRIC GetTextMetrics(IntPtr hwnd, Font font)
        {
            NativeMethods.TEXTMETRIC tEXTMETRIC;
            IntPtr windowDC = NativeMethods.GetWindowDC(hwnd);
            IntPtr hfont = font.ToHfont();
            try
            {
                IntPtr intPtr = NativeMethods.SelectObject(windowDC, hfont);
                NativeMethods.GetTextMetrics(windowDC, out tEXTMETRIC);
                NativeMethods.SelectObject(windowDC, intPtr);
            }
            finally
            {
                NativeMethods.ReleaseDC(hwnd, windowDC);
                NativeMethods.DeleteObject(hfont);
            }
            return tEXTMETRIC;
        }

        private void IPAddressControl_DragDrop(object sender, DragEventArgs e)
        {
            Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void IPAddressControl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
            e.Effect = DragDropEffects.None;
        }

        private void LayoutControls()
        {
            base.SuspendLayout();
            int width = base.Width - MinimumSize.Width;
            int length = _fieldControls.Length + _dotControls.Length + 1;
            int num = width / length;
            int num1 = width % length;
            var numArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                numArray[i] = num;
                if (i < num1)
                {
                    numArray[i] = numArray[i] + 1;
                }
            }
            int width1 = 0;
            int height = 0;
            switch (BorderStyle)
            {
                case BorderStyle.FixedSingle:
                    {
                        width1 = FixedSingleOffset.Width;
                        height = FixedSingleOffset.Height;
                        break;
                    }
                case BorderStyle.Fixed3D:
                    {
                        width1 = Fixed3DOffset.Width;
                        height = Fixed3DOffset.Height;
                        break;
                    }
            }
            int num2 = 0;
            int num3 = num2;
            num2 = num3 + 1;
            width1 = width1 + numArray[num3];
            for (int j = 0; j < _fieldControls.Length; j++)
            {
                _fieldControls[j].Location = new Point(width1, height);
                width1 = width1 + _fieldControls[j].Width;
                if (j < _dotControls.Length)
                {
                    int num4 = num2;
                    num2 = num4 + 1;
                    width1 = width1 + numArray[num4];
                    _dotControls[j].Location = new Point(width1, height);
                    width1 = width1 + _dotControls[j].Width;
                    int num5 = num2;
                    num2 = num5 + 1;
                    width1 = width1 + numArray[num5];
                }
            }
            base.ResumeLayout(false);
        }

        private void OnCedeFocus(object sender, CedeFocusEventArgs e)
        {
            switch (e.Action)
            {
                case Action.Trim:
                    {
                        if (e.FieldIndex == 0)
                        {
                            return;
                        }
                        _fieldControls[e.FieldIndex - 1].TakeFocus(Action.Trim);
                        return;
                    }
                case Action.Home:
                    {
                        _fieldControls[0].TakeFocus(Action.Home);
                        return;
                    }
                case Action.End:
                    {
                        _fieldControls[3].TakeFocus(Action.End);
                        return;
                    }
            }
            if (e.Direction == Direction.Reverse && e.FieldIndex == 0 ||
                e.Direction == Direction.Forward && e.FieldIndex == 3)
            {
                return;
            }
            int fieldIndex = e.FieldIndex;
            fieldIndex = (e.Direction != Direction.Forward ? fieldIndex - 1 : fieldIndex + 1);
            _fieldControls[fieldIndex].TakeFocus(e.Direction, e.Selection);
        }

        private void OnFieldGotFocus(object sender, EventArgs e)
        {
            if (!_focused)
            {
                _focused = true;
                base.OnGotFocus(EventArgs.Empty);
            }
        }

        private void OnFieldKeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void OnFieldKeyPressed(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void OnFieldKeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void OnFieldLostFocus(object sender, EventArgs e)
        {
            if (!Focused)
            {
                _focused = false;
                base.OnLostFocus(EventArgs.Empty);
            }
        }

        private void OnFieldPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            OnPreviewKeyDown(e);
        }

        private void OnFieldTextChanged(object sender, TextChangedEventArgs e)
        {
            if (FieldChangedEvent != null)
            {
                var fieldChangedEventArg = new FieldChangedEventArgs
                {
                    FieldIndex = e.FieldIndex,
                    Text = e.Text
                };
                FieldChangedEvent(this, fieldChangedEventArg);
            }
            OnTextChanged(EventArgs.Empty);
        }

        private void OnSubControlClicked(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void OnSubControlDoubleClicked(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }

        private void OnSubControlMouseClicked(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void OnSubControlMouseDoubleClicked(object sender, MouseEventArgs e)
        {
            OnMouseDoubleClick(e);
        }

        private void OnSubControlMouseEntered(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void OnSubControlMouseHovered(object sender, EventArgs e)
        {
            OnMouseHover(e);
        }

        private void OnSubControlMouseLeft(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void OnSubControlMouseMoved(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        private void Parse(string text)
        {
            Clear();
            if (text == null)
            {
                return;
            }
            int length = 0;
            int i;
            for (i = 0; i < _dotControls.Length; i++)
            {
                int num = text.IndexOf(_dotControls[i].Text, length, StringComparison.Ordinal);
                if (num < 0)
                {
                    break;
                }
                _fieldControls[i].Text = text.Substring(length, num - length);
                length = num + _dotControls[i].Text.Length;
            }
            _fieldControls[i].Text = text.Substring(length);
        }

        private void ResetBackColorChanged()
        {
            _backColorChanged = false;
        }

        private bool HasMouse
        {
            get
            {
                Rectangle displayRectangle = DisplayRectangle;
                return displayRectangle.Contains(base.PointToClient(MousePosition));
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Cleanup();
            }
            base.Dispose(disposing);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            _backColorChanged = true;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            AdjustSize();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            _focused = true;
            _fieldControls[0].TakeFocus(Direction.Forward, Selection.All);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (!Focused)
            {
                _focused = false;
                base.OnLostFocus(e);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!_hasMouse)
            {
                _hasMouse = true;
                base.OnMouseEnter(e);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!HasMouse)
            {
                base.OnMouseLeave(e);
                _hasMouse = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e");
            }
            base.OnPaint(e);
            Color backColor = BackColor;
            if (!_backColorChanged && (!base.Enabled || ReadOnly))
            {
                backColor = SystemColors.Control;
            }
            using (var solidBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(solidBrush, ClientRectangle);
            }
            int left = base.ClientRectangle.Left;
            int top = base.ClientRectangle.Top;
            Rectangle clientRectangle = base.ClientRectangle;
            Rectangle rectangle = base.ClientRectangle;
            var rectangle1 = new Rectangle(left, top, clientRectangle.Width - 1, rectangle.Height - 1);
            switch (BorderStyle)
            {
                case BorderStyle.FixedSingle:
                    {
                        ControlPaint.DrawBorder(e.Graphics, ClientRectangle, SystemColors.WindowFrame,
                            ButtonBorderStyle.Solid);
                        return;
                    }
                case BorderStyle.Fixed3D:
                    {
                        if (!Application.RenderWithVisualStyles)
                        {
                            ControlPaint.DrawBorder3D(e.Graphics, ClientRectangle, Border3DStyle.Sunken);
                            return;
                        }
                        using (var pen = new Pen(VisualStyleInformation.TextControlBorder))
                        {
                            e.Graphics.DrawRectangle(pen, rectangle1);
                        }
                        rectangle1.Inflate(-1, -1);
                        e.Graphics.DrawRectangle(SystemPens.Window, rectangle1);

                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AdjustSize();
        }

        public void Clear()
        {
            FieldControl[] fieldControlArray = _fieldControls;
            for (int i = 0; i < fieldControlArray.Length; i++)
            {
                fieldControlArray[i].Clear();
            }
        }

        public byte[] GetAddressBytes()
        {
            var value = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                value[i] = _fieldControls[i].Value;
            }
            return value;
        }

        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames",
            Justification = "Using Bytes seems more informative than SetAddressValues.")]
        public void SetAddressBytes(byte[] bytes)
        {
            Clear();
            if (bytes == null)
            {
                return;
            }
            int num = Math.Min(4, bytes.Length);
            for (int i = 0; i < num; i++)
            {
                _fieldControls[i].Text = bytes[i].ToString(CultureInfo.InvariantCulture);
            }
        }

        public void SetFieldFocus(int fieldIndex)
        {
            if (fieldIndex >= 0 && fieldIndex < 4)
            {
                _fieldControls[fieldIndex].TakeFocus(Direction.Forward, Selection.All);
            }
        }

        public void SetFieldRange(int fieldIndex, byte rangeLower, byte rangeUpper)
        {
            if (fieldIndex >= 0 && fieldIndex < 4)
            {
                _fieldControls[fieldIndex].RangeLower = rangeLower;
                _fieldControls[fieldIndex].RangeUpper = rangeUpper;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                stringBuilder.Append(_fieldControls[i]);
                if (i < _dotControls.Length)
                {
                    stringBuilder.Append(_dotControls[i]);
                }
            }
            return stringBuilder.ToString();
        }

        [Browsable(true)]
        public bool AllowInternalTab
        {
            get
            {
                FieldControl[] fieldControlArray = _fieldControls;
                int num = 0;
                if (num >= fieldControlArray.Length)
                {
                    return false;
                }
                return fieldControlArray[num].TabStop;
            }
            set
            {
                FieldControl[] fieldControlArray = _fieldControls;
                foreach (FieldControl t in fieldControlArray)
                {
                    t.TabStop = value;
                }
            }
        }

        [Browsable(true)]
        public bool AnyBlank
        {
            get
            {
                FieldControl[] fieldControlArray = _fieldControls;
                for (int i = 0; i < fieldControlArray.Length; i++)
                {
                    if (fieldControlArray[i].Blank)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        [Browsable(true)]
        public bool AutoHeight
        {
            get { return _autoHeight; }
            set
            {
                _autoHeight = value;
                if (_autoHeight)
                {
                    AdjustSize();
                }
            }
        }

        [Browsable(false)]
        public int Baseline
        {
            get
            {
                NativeMethods.TEXTMETRIC textMetrics = GetTextMetrics(Handle, Font);
                int height = textMetrics.tmAscent + 1;
                switch (BorderStyle)
                {
                    case BorderStyle.FixedSingle:
                        {
                            height = height + FixedSingleOffset.Height;
                            break;
                        }
                    case BorderStyle.Fixed3D:
                        {
                            height = height + Fixed3DOffset.Height;
                            break;
                        }
                }
                return height;
            }
        }

        [Browsable(true)]
        public bool Blank
        {
            get
            {
                FieldControl[] fieldControlArray = _fieldControls;
                for (int i = 0; i < fieldControlArray.Length; i++)
                {
                    if (!fieldControlArray[i].Blank)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        [Browsable(true)]
        public BorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                AdjustSize();
                Invalidate();
            }
        }

        [Browsable(false)]
        public override bool Focused
        {
            get
            {
                FieldControl[] fieldControlArray = _fieldControls;
                for (int i = 0; i < fieldControlArray.Length; i++)
                {
                    if (fieldControlArray[i].Focused)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IPAddress IPAddress
        {
            get { return new IPAddress(GetAddressBytes()); }
            set
            {
                Clear();
                if (value == null)
                {
                    return;
                }
                if (value.AddressFamily == AddressFamily.InterNetwork)
                {
                    SetAddressBytes(value.GetAddressBytes());
                }
            }
        }

        [Browsable(true)]
        public override Size MinimumSize
        {
            get { return CalculateMinimumSize(); }
        }

        [Browsable(true)]
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                FieldControl[] fieldControlArray = _fieldControls;
                foreach (FieldControl t in fieldControlArray)
                {
                    t.ReadOnly = _readOnly;
                }
                DotControl[] dotControlArray = _dotControls;
                foreach (DotControl t in dotControlArray)
                {
                    t.ReadOnly = _readOnly;
                }
                base.Invalidate();
            }
        }

        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                var stringBuilder = new StringBuilder();
                for (int i = 0; i < _fieldControls.Length; i++)
                {
                    stringBuilder.Append(_fieldControls[i].Text);
                    if (i < _dotControls.Length)
                    {
                        stringBuilder.Append(_dotControls[i].Text);
                    }
                }
                return stringBuilder.ToString();
            }
            set { Parse(value); }
        }
    }
}