using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current
{
    public partial class Transactions : UserControl
    {
        private bool editmode { get; set; }
        private string lastvalue { get; set; }

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Page_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = new ORM.Tables.Current.Transactions().SelectDB();
        }

        private void Search_ıconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to search in Currents, You have to go List Page on Menu.", "For Search.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_ıconButton_Click(object sender, EventArgs e)
        {

            new AddsAndRemoves.Transactions_Add().Show();
        }

        private void edit_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbox = (sender as CheckBox);
            if (editmode)
            {
                cbox.Text = "Edit Mode: DISABLE";
                cbox.BackColor = Color.FromArgb(231, 111, 81);
                editmode = false;
            }
            else
            {
                cbox.Text = "Edit Mode: ENABLE";
                cbox.BackColor = Color.FromArgb(0, 255, 0);
                editmode = true;
            }
            MessageBox.Show(editmode.ToString());
        }

        private double ToDouble(int RowIndex, int cellIndex)
        {
            return Double.Parse(
                dataGridView.Rows[RowIndex].Cells[cellIndex].Value.ToString(),
                NumberStyles.AllowCurrencySymbol |
                NumberStyles.AllowDecimalPoint |
                NumberStyles.AllowThousands,
                new CultureInfo("en-US")
                );
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Entity.Current current = new Entity.Current();
            current.CurrentID = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value;
            current.Code = (int)dataGridView.Rows[e.RowIndex].Cells[1].Value;
            current.Title = (string)dataGridView.Rows[e.RowIndex].Cells[2].Value;
            current.Debt = ToDouble(e.RowIndex, 3);
            current.Payee = ToDouble(e.RowIndex, 4);
            current.Address = (string)dataGridView.Rows[e.RowIndex].Cells[5].Value;
            current.City = (string)dataGridView.Rows[e.RowIndex].Cells[6].Value;
            current.District = (string)dataGridView.Rows[e.RowIndex].Cells[7].Value;
            current.Phone1 = (long)dataGridView.Rows[e.RowIndex].Cells[8].Value;
            current.Phone2 = (long)dataGridView.Rows[e.RowIndex].Cells[9].Value;
            current.MobilPhone = (long)dataGridView.Rows[e.RowIndex].Cells[10].Value;
            current.TaxNo = (string)dataGridView.Rows[e.RowIndex].Cells[11].Value;
            current.PersonalID = (int)dataGridView.Rows[e.RowIndex].Cells[12].Value;
            current.DateTime = (DateTime)dataGridView.Rows[e.RowIndex].Cells[13].Value;
            current.Explain = (string)dataGridView.Rows[e.RowIndex].Cells[14].Value;

            MessageBox.Show(
            current.CurrentID.ToString() +
            current.Code.ToString() +
            current.Title.ToString() +
            current.Debt.ToString() +
            current.Payee.ToString() +
            current.Address.ToString() +
            current.City.ToString() +
            current.District.ToString() +
            current.Phone1.ToString() +
            current.Phone2.ToString() +
            current.MobilPhone.ToString() +
            current.TaxNo.ToString() +
            current.PersonalID.ToString() +
            current.DateTime.ToString() +
            current.Explain.ToString()
                );
            //new ORM.Tables.Current.Transactions().Update();
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lastvalue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
