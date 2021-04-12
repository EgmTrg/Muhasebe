using Muhasebe.Pages;
using System.Windows.Forms;

namespace Muhasebe
{
    public static class PageManagement
    {
        private static void OpenPage(Form page)
        {
            if (page.IsDisposed)
            {
                page = new StokTakip();
                page.Show();
            }
            else
                page.BringToFront();
        }
    }
}
