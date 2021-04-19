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

        #region Hotkeys
        private void LoginRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (login_panel.Visible && e.KeyCode == Keys.Enter)
                loginOnLogin_button.PerformClick();
            if (register_panel.Visible && e.KeyCode == Keys.Enter)
                registerOnRegister_button.PerformClick();

        }
        #endregion

        #region Buttons Properties
        private void loginOnLogin_button_Click(object sender, System.EventArgs e)
        {
            bool loginStatus = new ORM.Tables.Users().Login(usernameOnLogin_textBox.Text, passwordOnLogin_maskedTextBox.Text, remember_checkBox.Checked);
            if (loginStatus)
            { /*MainForm will opening here.*/}

            else
                MessageBox.Show("Username or password is incorrect. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void registerOnRegister_button_Click(object sender, System.EventArgs e)
        {

        }

        private void register_button_Click(object sender, System.EventArgs e)
        {
            PanelChance();
        }
        #endregion

        #region Little Properties
        private void username_textBox_Enter(object sender, System.EventArgs e)
        {
            usernameOnLogin_textBox.SelectAll();
        }

        private void password_maskedTextBox_Enter(object sender, System.EventArgs e)
        {
            passwordOnLogin_maskedTextBox.SelectAll();
        }
        #endregion

        #region Custom Methods
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
        #endregion
    }
}
