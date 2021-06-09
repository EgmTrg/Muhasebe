using System;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current.AddsAndRemoves
{
    public partial class Transactions_Add : Form
    {
        ORM.Tables.Current.Transactions ORMTransactionsPage = new ORM.Tables.Current.Transactions();

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

        private void autoFill_button_Click(object sender, EventArgs e)
        {
            DialogResult autofill = MessageBox.Show("Are you sure? This selection can not change again.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (autofill == DialogResult.Yes)
            {
                code_numericUpDown.Enabled = false;
                code_numericUpDown.Value = ORMTransactionsPage.CreateCurrentCode();
            }
        }

        private void debt_textBox_Leave(object sender, EventArgs e)
        {
            Debt_INT_VALUE_Label.Text = debt_textBox.Text;
            try
            {
                debt_textBox.Text = double.Parse(debt_textBox.Text).ToString("C2");
            }
            catch (Exception)
            {
                debt_textBox.Text = string.Empty;
            }
        }

        private void payee_textBox_Leave(object sender, EventArgs e)
        {
            payee_INT_VALUE_Label.Text = payee_textBox.Text;
            try
            {
                payee_textBox.Text = double.Parse(payee_textBox.Text).ToString("C2");
            }
            catch (Exception)
            {
                MessageBox.Show("Please write only numeric and dont copy paste.");
                debt_textBox.Text = string.Empty;
            }
        }
        #endregion

        private void Add_ıconButton_Click(object sender, EventArgs e)
        {
            Entity.Current newCurrent = new Entity.Current();

            newCurrent.Code = Convert.ToInt32(code_numericUpDown.Value);

            newCurrent.Title = title_textBox.Text;

            newCurrent.Debt = Convert.ToDouble(Debt_INT_VALUE_Label.Text);
            newCurrent.Payee = Convert.ToDouble(payee_INT_VALUE_Label.Text);

            newCurrent.Address = address_textBox.Text;
            newCurrent.City = city_textBox.Text;
            newCurrent.District = disctict_textBox.Text;
            newCurrent.Phone1 = Convert.ToInt64(phone1_textBox.Text);
            newCurrent.Phone2 = Convert.ToInt64(phone2_textBox.Text);
            newCurrent.MobilPhone = Convert.ToInt64(mobilPhone_textBox.Text);

            newCurrent.TaxNo = taxNo_textBox.Text;
            newCurrent.PersonalID = Convert.ToInt32(personalID_textBox.Text);

            newCurrent.DateTime = dateTimePicker.Value.Date;
            newCurrent.Explain = explain_richTextBox.Text;

            MessageBox.Show(ORMTransactionsPage.Insert(newCurrent).ToString()); 
        }

        private void code_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ORMTransactionsPage.CurrentCodeControl((int)code_numericUpDown.Value))
            {
                DialogResult dialog = MessageBox.Show($"This code ({code_numericUpDown.Value}) already used. Do you want to generate a new code?", "Already have.", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes)
                    autoFill_button.PerformClick();
            }
        }

        private void ClearAll_ıconButton_Click(object sender, EventArgs e)
        {
            code_numericUpDown.Value = 0;
            title_textBox.Text = string.Empty;
            address_textBox.Text = string.Empty;
            city_textBox.Text = string.Empty;
            disctict_textBox.Text = string.Empty;
            phone1_textBox.Text = string.Empty;
            phone2_textBox.Text = string.Empty;
            mobilPhone_textBox.Text = string.Empty;
            debt_textBox.Text = string.Empty;
            payee_textBox.Text = string.Empty;
            taxNo_textBox.Text = string.Empty;
            personalID_textBox.Text = string.Empty;
            explain_richTextBox.Text = string.Empty;
        }

        private void debt_textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).Text = string.Empty;
        }
    }
}
