using Muhasebe.Pages;
using System;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class MainForm : Form
    {
        StokTakip stokTakip = new StokTakip();


        public MainForm()
        {
            InitializeComponent();
        }

        private void stokTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPage(stokTakip);
        }

        private void OpenPage(Form page)
        {
            if (page.IsDisposed)
            {
                page = new StokTakip();
                page.MdiParent = this;
                page.ShowDialog();
            }
            else
                page.BringToFront();
        }
    }
}
