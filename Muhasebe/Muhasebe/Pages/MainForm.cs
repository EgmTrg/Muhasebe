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

        public MainForm(string username, Form LR)
        {
            InitializeComponent();
            currentUsername_label.Text = username + "'s Account";
            FormClosed += (sender, eventArgs) => LR.Close();
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

        private void menubar_treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString() == "ParentNode")
            {
                e.Node.Expand();
                return;
            }

            switch (e.Node.Text)
            {
                case "Homepage":
                    ChangePage(new Homepage());
                    break;
                case "List":
                    ChangePage(new SubPages.Current.List());
                    break;
            }
            main_panel.Focus();
        }
    }
}
