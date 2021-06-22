using System;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current
{
    public partial class Transactions : UserControl
    {
        private bool editmode { get; set; }

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Page_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ORM.Tables.Current.Transactions().SelectDB();
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
                cbox.BackColor = Color.FromArgb(0,255,0);
                editmode = true;
            }
            MessageBox.Show(editmode.ToString());
        }
    }
}
