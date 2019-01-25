using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterSys
{
    public class Common
    {
        System.Windows.Forms.Form Owner;
        public Common(System.Windows.Forms.Form Parent)
        {
            this.Owner = Parent;
        }

        public void ShowFilter()
        {
            formFilter filter = new formFilter();
            filter.ShowDialog(this.Owner as System.Windows.Forms.IWin32Window);
        }
    }
}
