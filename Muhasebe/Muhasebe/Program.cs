using Muhasebe.LoginRegister;
using System;
using System.Windows.Forms;

namespace Muhasebe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginRegister());
        }
    }
}
