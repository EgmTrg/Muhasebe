using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages
{
    public partial class Homepage : UserControl
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Daily_groupBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            // Here decide which color will we use and how many will be thickness the pen should be.
            Pen p = new Pen(Color.FromArgb(38, 70, 83), 3);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2); // VERTICAL LEFT COLUMN
            gfx.DrawLine(p, 0, 5, 5, 5); // SORT TOP LINE (LEFT SIDE)
            gfx.DrawLine(p, 170, 5, e.ClipRectangle.Width - 2, 5); // LONG TOP LINE (RIGHT SIDE)
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); // VERTICAL RIGHT COLUMN
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); // BOTTOM LINE
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            // Here decide which color will we use and how many will be thickness the pen should be.
            Pen p = new Pen(Color.FromArgb(38, 70, 83), 3); 
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2); // VERTICAL LEFT COLUMN
            gfx.DrawLine(p, 0, 5, 5, 5); // SORT TOP LINE (LEFT SIDE)
            gfx.DrawLine(p, 83, 5, e.ClipRectangle.Width - 2, 5); // LONG TOP LINE (RIGHT SIDE)
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2); // VERTICAL RIGHT COLUMN
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2); // BOTTOM LINE
        }

        private void Homepage_Load(object sender, System.EventArgs e)
        {

        }
    }
}
