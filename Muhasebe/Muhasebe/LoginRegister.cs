using System.Windows.Forms;

namespace Muhasebe
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();

        }
        private void Login_Load(object sender, System.EventArgs e)
        {
            register_panel.Location = new System.Drawing.Point(12, 12);
            PanelChance();
        }

        private void PanelChance()
        {
            if (register_panel.Visible)
            {
                register_panel.Visible = false;
                login_panel.Visible = true;
                this.Size = new System.Drawing.Size(358, 355);
                login_panel.BringToFront();
            }
            else
            {
                register_panel.Visible = true;
                login_panel.Visible = false;
                this.Size = new System.Drawing.Size(358, 537);
                register_panel.BringToFront();
            }
        }

        #region Some Properties
        private void username_textBox_Enter(object sender, System.EventArgs e)
        {
            usernameOnLogin_textBox.SelectAll();
        }

        private void password_maskedTextBox_Enter(object sender, System.EventArgs e)
        {
            passwordOnLogin_maskedTextBox.SelectAll();
        }
        #endregion

        private void login_button_Click(object sender, System.EventArgs e)
        {
            if (remember_checkBox.Checked) 
            {
                // do remember stuffs
            }
        }

        private void register_button_Click(object sender, System.EventArgs e)
        {
            PanelChance();
        }       
    }
}
