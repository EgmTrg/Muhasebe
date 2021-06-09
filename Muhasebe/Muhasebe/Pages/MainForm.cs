using Muhasebe.Pages.SubPages;
using System.Windows.Forms;

namespace Muhasebe.Pages
{
    public partial class MainForm : Form
    {
        private UserControl _CURRENT_PAGE = null;

        /// <summary>
        /// Use this feature for ONLY references.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string username)
        {
            InitializeComponent();
            currentUsername_label.Text = username + "'s Account";
        }

        public MainForm(string username, Form LoginRegister)
        {
            InitializeComponent();
            currentUsername_label.Text = username + "'s Account";
            FormClosed += (sender, eventArgs) => LoginRegister.Close();
        }

        public virtual void ChangePage(UserControl newPage)
        {
            if (_CURRENT_PAGE != null)
                _CURRENT_PAGE.Dispose();

            _CURRENT_PAGE = newPage;
            main_panel.Controls.Add(newPage);
            newPage.Dock = DockStyle.Fill;
            newPage.BringToFront();
            newPage.Show();
        }

        private void menubar_treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString() == "ParentNode")
            {
                e.Node.Expand();
                return;
            }
            switch (e.Node.ToolTipText)
            {
                case "Homepage":
                    ChangePage(new Homepage());
                    break;
                case "Current_List":
                    ChangePage(new SubPages.Current.List());
                    break;
                case "Current_Transactions":
                    ChangePage(new SubPages.Current.Transactions());
                    break;
                case "Stock_List":
                    ChangePage(new SubPages.Stock.StockList());
                    break;
            }
            main_panel.Focus();
        }
        // fromnode parametresi eklendi. degisiklikler uygulandi ekstra if parametresi eklendi
    }
}
