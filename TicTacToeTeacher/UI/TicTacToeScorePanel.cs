using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToeTeacher.UI
{
    public partial class TicTacToeScorePanel : Panel
    {
        private Color _fillColor = Color.FromArgb(51, 49, 50);
        private int _roundAmmount = 9;
        private int _score = 0;
        private string _text = string.Empty;
        private bool _inverted = false;

        [Category("Custom"), Description("Determines which color the object is filled with.")]
        public Color FillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; this.Refresh(); }
        }

        [Category("Custom"), Description("Determines objects round ammount.")]
        public int RoundAmmount
        {
            get { return _roundAmmount; }
            set { _roundAmmount = value; this.Refresh(); }
        }

        [Category("Custom")]
        public int Score
        {
            get { return _score; }
            set { _score = value; this.Refresh(); }
        }

        [Category("Custom")]
        public string InnerText
        {
            get { return _text; }
            set { _text = value; this.Refresh(); }
        }

        [Category("Custom")]
        public bool Inverted
        {
            get { return _inverted; }
            set { _inverted = value; this.Refresh(); }
        }

        public TicTacToeScorePanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (GraphicsPath ShadowPath = Tools.RoundedRect(new Rectangle(2, 2, this.Width - 3, this.Height - 3), _roundAmmount))
            {
                using (Brush b = new SolidBrush(Color.FromArgb(100, _fillColor)))
                    e.Graphics.FillPath(b, ShadowPath);
            }
            using (GraphicsPath path = Tools.RoundedRect(new Rectangle(0, 0, this.Width - 4, this.Height - 4), _roundAmmount))
            {
                using (Brush b = new SolidBrush(_fillColor))
                    e.Graphics.FillPath(b, path);

                StringFormat format = new StringFormat()
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near,
                };

                SizeF TextSize = e.Graphics.MeasureString(_text, this.Font);
                using (Brush p = new SolidBrush(this.ForeColor))
                {
                    int holder = (int)TextSize.Width + 1;
                    if (_inverted)
                    {
                        format.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(_text, this.Font, p, new Rectangle(this.Width - (_roundAmmount + holder), 0, holder, this.Height - 4), format);
                        format.Alignment = StringAlignment.Near;
                        e.Graphics.DrawString(_score + "", this.Font, p, new Rectangle(_roundAmmount / 2, 0, this.Width - (_roundAmmount + holder), this.Height - 4), format);
                    }
                    else
                    {
                        e.Graphics.DrawString(_text, this.Font, p, new Rectangle(_roundAmmount, 0, holder, this.Height - 4), format);
                        format.Alignment = StringAlignment.Far;
                        e.Graphics.DrawString(_score + "", this.Font, p, new Rectangle(_roundAmmount + holder, 0, this.Width - (_roundAmmount * 2 + holder), this.Height - 4), format);
                    }
                }
            }
        }
    }
}
