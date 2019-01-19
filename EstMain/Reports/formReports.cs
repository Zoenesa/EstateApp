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

        public formReports(string fileReportTrd, string Connectionstring, string Command, string HeaderText = "")
        {
            InitializeComponent();
            this._fileReportTrd = fileReportTrd;
            this.ConnectionString = Connectionstring;
            this.Command = Command;
            this.HeaderText = HeaderText;
        }

        private string _fileReportTrd;
        private string ConnectionString;
        private string Command;
        private string HeaderText;

        void InitReport()
        {
            try
            {
                Telerik.Reporting.ReportSource reportSource = null;
                this.ConnectionString = $"{this.ConnectionString};pwd=di5t0rti0n";
                ReportConnectionManager rcsm = new ReportConnectionManager(this.ConnectionString, Command);
                var uriSource = new Telerik.Reporting.UriReportSource()
                {
                    Uri = this._fileReportTrd
                };
                reportSource =
                rcsm.UpdateReportSource(uriSource);
                if (!string.IsNullOrEmpty(this.HeaderText))
                {
                    rcsm.SetItemValue(reportSource, "ReportNameTextBox", this.HeaderText);
                }
                this.reportViewer.ReportSource = reportSource;
                this.reportViewer.Resources.ProcessingReportMessage = "Mohon Tunggu...";
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer.Resources.ProcessingReportMessage = ex.Message;
            }
        }

        private void formReports_Load(object sender, EventArgs e)
        {
            InitReport();
        }
    }
}
