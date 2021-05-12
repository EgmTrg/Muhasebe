using System.Data;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }
        
        private void List_Load(object sender, System.EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = new ORM.Tables.Current.CurrentList().SelectDB();
        }

        private void refreshList_iconButton_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

    }
}
