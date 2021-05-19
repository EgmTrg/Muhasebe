using System.Data;
using System.Windows.Forms;

namespace Muhasebe.Pages.SubPages.Current
{
    public partial class List : UserControl
    {
        RadioButton checkedRb;
        public List()
        {
            InitializeComponent();
            clearFilter_ıconButton.Visible = false;
        }

        private void List_Load(object sender, System.EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = new ORM.Tables.Current.CurrentList().SelectDB();
            }
            catch (System.Exception)
            {
                dataGridView1.DataSource = null;
                RefreshDataGrid();
            }
        }

        private void refreshList_iconButton_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            ORM.Tables.Current.CurrentList cList = new ORM.Tables.Current.CurrentList();
            string checkedSearchRB = GetCheckedSearchRadioBox();
            if (!checkedSearchRB.Equals("Empty"))
                cList.SearchFilter(checkedSearchRB, searchValue_richTextBox.Text).ToString();
            RefreshDataGrid();
        }

        private void clearFilter_ıconButton_Click(object sender, System.EventArgs e)
        {
            checkedRb.Checked = false;
            clearFilter_ıconButton.Visible = false;
            refreshList_iconButton.PerformClick();
        }

        private void SearchButtons_CheckedChanged(object sender, System.EventArgs e)
        {
            GetCheckedSearchRadioBox();
            clearFilter_ıconButton.Visible = true;
        }

        #region Custom Methods

        private string GetCheckedSearchRadioBox()
        {
            string checkedRbText = "Empty";
            RadioButton[] searchRadioButtons = {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4,
                radioButton5,
                radioButton6 };
            foreach (RadioButton radio in searchRadioButtons)
                if (radio.Checked)
                {
                    checkedRbText = radio.Text;
                    checkedRb = radio;
                }
            return checkedRbText;
        }
        #endregion
    }
}
