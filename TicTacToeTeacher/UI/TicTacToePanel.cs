using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToeTeacher.UI
{
    public partial class TicTacToePanel : Panel
    {
        public enum TicTacToeState
        {
            None,
            X,
            O,
        }

        private Color _fillColor = Color.FromArgb(51, 49, 50);
        private Color _fillHoverColor = Color.FromArgb(255, 128, 0);
        private Color _fillDownColor = Color.FromArgb(230, 120, 0);

        private bool _isHovered = false;
        private bool _isDown = false;

        private int _roundAmmount = 9;
        private TicTacToeState _currentState = TicTacToeState.None;

        [Category("Custom"), Description("Determines which color the object is filled with.")]
        public Color FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; this.Invalidate(); }
        }

        [Category("Custom"), Description("Determines which color the object is filled with.")]
        public Color FillHoverColor
        {
            get { return _fillHoverColor; }
            set { _fillHoverColor = value; this.Invalidate(); }
        }

        [Category("Custom"), Description("Determines which color the object is filled with.")]
        public Color FillDownColor
        {
            get { return _fillDownColor; }
            set { _fillDownColor = value; this.Invalidate(); }
        }

        [Category("Custom"), Description("Determines objects round ammount.")]
        public int RoundAmmount
        {
            get { return _roundAmmount; }
            set { _roundAmmount = value; this.Invalidate(); }
        }

        [Category("Custom")]
        public TicTacToeState CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; this.Invalidate(); }
        }

        public TicTacToePanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (GraphicsPath path = Tools.RoundedRect(new Rectangle(0, 0, this.Width - 1, this.Height - 1), _roundAmmount))
            {
                using (Brush b = new SolidBrush(_isHovered ? (_isDown ? _fillDownColor : _fillHoverColor) : _fillColor))
                    e.Graphics.FillPath(b, path);

                if (_currentState != TicTacToeState.None)
                {
                    using (Brush b = new SolidBrush(this.ForeColor))
                    {
                        StringFormat format = new StringFormat()
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center,
                        };
                        e.Graphics.DrawString(_currentState == TicTacToeState.O ? "O" : "✖", this.Font, b, new Rectangle(0, 0, this.Width, this.Height), format);
                    }
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            this.Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDown = false;
                this.Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDown = true;
                this.Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isDown = false;
            _isHovered = false;
            this.Invalidate();
            base.OnMouseLeave(e);
        }
    }
}
