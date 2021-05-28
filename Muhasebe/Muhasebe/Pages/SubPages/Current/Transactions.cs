using System;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current
{
    public partial class Transactions : UserControl
    {
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
            //new Utility().ChangePage(new AddsAndRemoves.Add_Transactions(), true);
            new AddsAndRemoves.Transactions_Add().Show();
        }

        private void Remove_ıconButton_Click(object sender, EventArgs e)
        {

        }
    }
}
