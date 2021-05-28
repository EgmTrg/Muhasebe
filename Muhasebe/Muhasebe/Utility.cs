using System.Windows.Forms;

namespace Muhasebe
{
    public class Utility : Pages.MainForm
    {
        public override void ChangePage(UserControl newPage,bool FromNode)
        {
            base.ChangePage(newPage,true);
        }
    }
}
