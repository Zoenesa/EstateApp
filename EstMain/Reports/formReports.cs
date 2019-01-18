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
    public partial class formReports : RadForm
    {
        public formReports()
        {
            InitializeComponent();
        }

        private void formReports_Load(object sender, EventArgs e)
        {
            //Telerik.Reporting.UriReportSource uri = new Telerik.Reporting.UriReportSource();
            //uri.Uri = System.IO.Path.Combine(Environment.CurrentDirectory, "Reports", "Data Order KWH.trdp");
            //reportViewer.ReportSource = uri;
            reportViewer.ReportSource = null;
            Telerik.Reporting.SqlDataSource dataSource = new Telerik.Reporting.SqlDataSource();
            Reports.ME.dataOrderKWH orderkwh = new Reports.ME.dataOrderKWH();
            Type t = orderkwh.GetType();
            Telerik.Reporting.TypeReportSource type = new Telerik.Reporting.TypeReportSource();
            type.TypeName = orderkwh.GetType().FullName;
            string s = orderkwh.GetType().ToString();
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetAssembly(t);
            s = asm.ToString();
            type.TypeName = orderkwh.GetType().ToString() + ", " + s;
            this.Text = type.TypeName;
            reportViewer.ReportSource = type;
            reportViewer.RefreshReport();
        }
    }
}
