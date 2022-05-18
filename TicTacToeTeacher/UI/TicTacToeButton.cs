using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToeTeacher.UI
{
    public partial class TicTacToeButton : Panel
    {
        private Color _fillColor = Color.FromArgb(51, 49, 50);
        private Color _fillHoverColor = Color.FromArgb(255, 128, 0);
        private Color _fillDownColor = Color.FromArgb(230, 120, 0);
        private int _roundAmmount = 9;
        private int _shadowOffset = 2;
        private bool _isHovered = false;
        private bool _isDown = false;
        private string _innerText;
        private StringAlignment _line = StringAlignment.Center;
        private StringAlignment _alignment = StringAlignment.Center;

        [Category("Custom"), Description("Determines which color the object is filled with.")]
        public Color FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; this.Refresh(); }
        }

        [Category("Custom")]
        public Color FillHoverColor
        {
            get { return _fillHoverColor; }
            set { _fillHoverColor = value; this.Refresh(); }
        }

        [Category("Custom")]
        public Color FillDownColor
        {
            get { return _fillDownColor; }
            set { _fillDownColor = value; this.Refresh(); }
        }

        [Category("Custom"), Description("Determines objects round ammount.")]
        public int RoundAmmount
        {
            get { return _roundAmmount; }
            set { _roundAmmount = value; this.Refresh(); }
        }

        [Category("Custom")]
        public string InnerText
        {
            get { return _innerText; }
            set { _innerText = value; this.Refresh(); }
        }

        [Category("Custom")]
        public StringAlignment Line
        {
            get { return _line; }
            set { _line = value; this.Refresh(); }
        }

        [Category("Custom")]
        public StringAlignment Alignment
        {
            get { return _alignment; }
            set { _alignment = value; this.Refresh(); }
        }

        public TicTacToeButton()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            this.Refresh();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDown = false;
                this.Refresh();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDown = true;
                this.Refresh();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isDown = false;
            _isHovered = false;
            this.Refresh();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (!_isDown)
            {
                using (GraphicsPath shadowPath = Tools.RoundedRect(new Rectangle(_shadowOffset, _shadowOffset, this.Width - _shadowOffset - 1, this.Height - _shadowOffset - 1), _roundAmmount))
                using (Brush b = new SolidBrush(Color.FromArgb(100, _isHovered ? _fillHoverColor : _fillColor)))
                    e.Graphics.FillPath(b, shadowPath);
            }

            using (GraphicsPath Path = _isDown ? Tools.RoundedRect(new Rectangle(_shadowOffset, _shadowOffset, this.Width - _shadowOffset - 1, this.Height - _shadowOffset - 1), _roundAmmount) :
                Tools.RoundedRect(new Rectangle(0, 0, this.Width - _shadowOffset - 1, this.Height - _shadowOffset - 1), _roundAmmount))
            {
                using (Brush b = new SolidBrush(_isHovered ? (_isDown ? _fillDownColor : _fillHoverColor) : _fillColor))
                    e.Graphics.FillPath(b, Path);

                StringFormat format = new StringFormat()
                {
                    LineAlignment = _line,
                    Alignment = _alignment,
                };

                using (Brush p = new SolidBrush(this.ForeColor))
                    e.Graphics.DrawString(_innerText, this.Font, p, Path.GetBounds(), format);
            }
        }
    }
}
