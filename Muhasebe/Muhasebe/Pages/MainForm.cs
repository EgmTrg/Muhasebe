using Muhasebe.Pages.SubPages;
using System.Windows.Forms;

namespace Muhasebe.Pages
{
    public partial class MainForm : Form
    {
        private UserControl _CURRENT_PAGE = null;

        public MainForm(string username)
        {
            InitializeComponent();
            currentUsername_label.Text = username + "'s Account";
        }

        private void menubar_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (menubar_treeView.SelectedNode.Tag.ToString() == "ParentNode")
                return;

            switch (menubar_treeView.SelectedNode.Text)
            {
                case "Homepage":
                    ChangePage(new Homepage());
                    break;
                case "List":
                    ChangePage(new SubPages.Current.List());
                    break;
            }
        }

        #region Custom Methods
        private void ChangePage(UserControl newPage)
        {
            if (_CURRENT_PAGE != null)
                _CURRENT_PAGE.Dispose();

            _CURRENT_PAGE = newPage;
            main_panel.Controls.Add(newPage);
            newPage.Dock = DockStyle.Fill;
            newPage.BringToFront();
            newPage.Show();
        }
        #endregion
    }
}
