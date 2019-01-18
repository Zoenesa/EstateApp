using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EstMain
{
    public partial class mainForm : RadForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void radMenuOpenDatabase_Click(object sender, EventArgs e)
        {
            Util.Db.mdl mod = new Util.Db.mdl();
            try
            {
                bool _flag = mod.Connect();
                if (_flag)
                {
                    //Telerik.WinControls.RadMessageBox.Show(this, "Connected");
                    DataTable dt = mod.OpenTable("SELECT * FROM view_orderkwhsimple");
                    formDataOrder dataOrder = new formDataOrder(dt);
                    dataOrder.MdiParent = this;
                    dataOrder.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
