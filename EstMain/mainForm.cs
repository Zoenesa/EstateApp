using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public static Util.Db.mdl Modul { get; private set; }

        private void radMenuOpenDatabase_Click(object sender, EventArgs e)
        {
            Util.Db.mdl mod = new Util.Db.mdl();
            Modul = mod;
            try
            {
                bool _flag = mod.Connect();
                if (_flag)
                {
                    DataTable dt = mod.OpenTable("SELECT * FROM view_orderkwhsimple");
                    Commons.LoadTable init = new Commons.LoadTable(mod);
                    init.QuerySelect = "SELECT * FROM view_orderkwhsimple";
                    formDataOrder dataOrder = new formDataOrder(init);
                    dataOrder.MdiParent = this;
                    dataOrder.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radMenuItemOrderKWH_Click(object sender, EventArgs e)
        {
            string filetrd = Path.Combine(Environment.CurrentDirectory, "Reports", "Data Order KWH.trdp");
            if (!File.Exists(filetrd))
            {
                Telerik.WinControls.RadMessageBox.Show(this, new FileNotFoundException("File Report tidak ditemukan.").Message, "Error", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error);
            }
            string cmd = @"
                            SELECT
                            orderkwh.id AS ORDERID,
                            orderkwh.Nama AS NAMA,
                            CONCAT( list_kavling.KAVLING, '-', list_nomor.NOMOR ) AS `NO BLOK`,
                            orderkwh.`Nomor Pengajuan`,
                            orderkwh.Tanggal AS `TANGGAL ORDER`,
                            orderkwh.Daya,
                            orderkwh.Alamat,
                            list_kavling.`ID RECORD` AS `ID KAVLING`,
                            list_kavling.KAVLING AS `NAMA KAVLING`,
                            list_nomor.`ID RECORD` AS `ID NOMOR`,
                            list_nomor.NOMOR AS NOMOR,
                            statusorderkwh.statusname AS `STATUS ORDER` 
                            FROM orderkwh
                            INNER JOIN list_kavling ON orderkwh.Blok = list_kavling.`ID RECORD`
                            INNER JOIN list_nomor ON orderkwh.Nomor = list_nomor.`ID RECORD` 
                            INNER JOIN statusorderkwh ON orderkwh.Status = statusorderkwh.statuscode
                            ORDER BY ORDERID ASC ";
            formReports frmReport = new formReports(filetrd, Modul.Connection_String, cmd, "Data Permintaan Pasang Listrik / Meter KWH");
            frmReport.MdiParent = this;
            frmReport.Show();
        }
    }
}
