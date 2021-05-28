using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current.AddsAndRemoves
{
    public partial class Transactions_Add : Form
    {
        public Transactions_Add()
        {
            InitializeComponent();
        }
        #region Events
        private void GroupBoxLines_Paint(object sender, PaintEventArgs e)
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

        private void OnlyNumaricAcceptable_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void autoFill_button_Click(object sender, System.EventArgs e)
        {
            DialogResult autofill = MessageBox.Show("Are you sure? This selection can not change again.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (autofill == DialogResult.Yes)
            {
                code_numericUpDown.Enabled = false;
                code_numericUpDown.Value = LastCurrentCode();
            }
        }

        private void debt_textBox_TextChanged(object sender, EventArgs e)
        {
            debt_textBox.Text = double.Parse(debt_textBox.Text).ToString("C2");
        }

        private void payee_textBox_TextChanged(object sender, EventArgs e)
        {
            payee_textBox.Text = double.Parse(payee_textBox.Text).ToString("C2");
        }
        #endregion

        private int LastCurrentCode()
        {
            DataRow[] SQLCodeRows = new ORM.Tables.Current.CurrentList().SelectDB().Select();
            return SQLCodeRows.Length + 1;
        }

        private void Add_ıconButton_Click(object sender, System.EventArgs e)
        {
            bool autofill = code_numericUpDown.Enabled;
            string[] contact = { address_textBox.Text, city_textBox.Text, disctict_textBox.Text, phone1_textBox.Text, phone2_textBox.Text, mobilPhone_textBox.Text };
            double[] financial = { System.Convert.ToDouble(debt_textBox.Text), System.Convert.ToDouble(payee_textBox.Text) };
            string[] details = { taxNo_textBox.Text, personalID_textBox.Text, explain_richTextBox.Text };

            Entity.Current newCurrent = new Entity.Current();

            // this will be usable to future
            /*if (autofill)
                newCurrent.Code = Convert.ToInt32(code_numericUpDown.Value);
            else*/

            newCurrent.Code = LastCurrentCode();

            newCurrent.Title = title_textBox.Text;

            newCurrent.Debt = financial[0];
            newCurrent.Payee = financial[1];

            newCurrent.Address = contact[0];
            newCurrent.City = contact[1];
            newCurrent.District = contact[2];
            newCurrent.Phone1 = System.Convert.ToInt64(contact[3]);
            newCurrent.Phone2 = System.Convert.ToInt64(contact[4]);
            newCurrent.MobilPhone = System.Convert.ToInt64(contact[5]);

            newCurrent.TaxNo = details[0];
            newCurrent.PersonalID = System.Convert.ToInt32(details[1]);

            newCurrent.DateTime = dateTimePicker.Value;
            newCurrent.Explain = details[2];

            new ORM.Tables.Current.Transactions().Insert(newCurrent);
        }

        
    }
}
