using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToeTeacher.UI
{
    public partial class TicTacToeEndPanel : Panel
    {
        private int _roundAmmount = 12;
        private Color _fillColor = Color.FromArgb(41, 39, 40);

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

        public TicTacToeEndPanel()
        {
            InitializeComponent();
        }

        /*protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;
                return createParams;
            }
        }*/

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            using (GraphicsPath path = Tools.RoundedRect(new Rectangle(0, 0, this.Width - 1, this.Height - 1), _roundAmmount))
            {
                using (Brush b = new SolidBrush(_fillColor))
                    e.Graphics.FillPath(b, path);
            }
        }
    }
}
