using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstMain.Controls
{
    public partial class controlDataTable : UserControl
    {
        public DataTable Data_Table { get; set; }

        public controlDataTable()
        {
            InitializeComponent();
            this.datagrid.DataBindingComplete += Datagrid_DataBindingComplete;
            this.Dock = DockStyle.Fill;
        }

        private void Datagrid_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            this.labelTotalRecords.Text = $"Total Records: {this.datagrid.Rows.Count}";
        }

        public void SetDataSource()
        {
            this.datagrid.DataSource = this.Data_Table;
        }
    }
}
