using CiscoTools.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CiscoTools.IPAddressControl
{
    internal class DotControl : Control
    {
        private bool _backColorChanged;

        private bool _readOnly;

        private SizeF _sizeText;
        private readonly StringFormat _stringFormat;

        public DotControl()
        {
            Text = Resources.FieldSeperator;
            _stringFormat = StringFormat.GenericTypographic;
            _stringFormat.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
            BackColor = SystemColors.Window;
            base.Size = MinimumSize;
            base.TabStop = false;
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.FixedHeight, true);
            base.SetStyle(ControlStyles.FixedWidth, true);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            base.Size = MinimumSize;
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
            Color foreColor = ForeColor;
            if (!base.Enabled)
            {
                foreColor = SystemColors.GrayText;
            }
            else if (ReadOnly && !_backColorChanged)
            {
                foreColor = SystemColors.WindowText;
            }
            using (var solidBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(solidBrush, base.ClientRectangle);
            }
            using (var solidBrush1 = new SolidBrush(foreColor))
            {
                Rectangle clientRectangle = base.ClientRectangle;
                float width = clientRectangle.Width / 2f - _sizeText.Width / 2f;
                e.Graphics.DrawString(Text, Font, solidBrush1,
                    new RectangleF(width, 0f, _sizeText.Width, _sizeText.Height), _stringFormat);
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            BackColor = base.Parent.BackColor;
            _backColorChanged = true;
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
            ForeColor = base.Parent.ForeColor;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            base.Size = MinimumSize;
        }

        public override string ToString()
        {
            return Text;
        }

        public override Size MinimumSize
        {
            get
            {
                using (Graphics graphic = Graphics.FromHwnd(base.Handle))
                {
                    _sizeText = graphic.MeasureString(Text, Font, -1, _stringFormat);
                }
                _sizeText.Height = _sizeText.Height + 1f;
                return _sizeText.ToSize();
            }
        }

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                base.Invalidate();
            }
        }
    }
}