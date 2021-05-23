using System;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current.AddsAndRemoves
{
    public partial class Add_Transactions : UserControl
    {
        public Add_Transactions()
        {
            InitializeComponent();
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

        private void DebtAndPayee_TextChanged(object sender, EventArgs e)
        {
            double money = Convert.ToDouble((sender as TextBox).Text);
            (sender as TextBox).Text = money.ToString("C2");
        }

        private void OnlyNumericAcceptable(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
