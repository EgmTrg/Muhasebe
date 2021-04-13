using System.Data;
using System.Windows.Forms;

namespace Muhasebe.LoginRegister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Some Properties
        private void username_textBox_Enter(object sender, System.EventArgs e)
        {
            username_textBox.SelectAll();
        }

        private void password_maskedTextBox_Enter(object sender, System.EventArgs e)
        {
            password_maskedTextBox.SelectAll();
        }
        #endregion

        private void login_button_Click(object sender, System.EventArgs e)
        {
            

            if (checkBox1.Checked) 
            {
                // do remember stuffs
            }
        }

        private void register_button_Click(object sender, System.EventArgs e)
        {
            //new Regsiter().ShowDialog();
        }
    }
}
