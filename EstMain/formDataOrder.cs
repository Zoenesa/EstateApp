using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace EstMain
{
    public partial class formDataOrder : RadForm
    {
        public formDataOrder()
        {
            InitializeComponent();
        }

        public DataTable DataTable { get { return _datatable; } }

        DataTable _datatable { get; set; }

        GridViewColumnCollection columns;

        public formDataOrder(DataTable table)
        {
            InitializeComponent();
            this.Text = "View Data Pengajuan KWH";
            this.radGridView1.EnableFiltering = false;
            this.radGridView1.GroupSummaryEvaluate += RadGridView1_GroupSummaryEvaluate;
            this._datatable = table;
            InitializeData();
            //radDropDownList1.DataSource = columns as IEnumerable<GridViewColumn>;
        }

        private void RadGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            //if (e.SummaryItem.Name == "KAVLING")
            //{
            //    e.FormatString = $"Kategori Kavling: {e.Value}";
            //}
            //else if (e.SummaryItem.Name == "Nomor Pengajuan")
            //{
            //    e.FormatString = $"Kategori Pengajuan: {e.Value}";
            //}
        }

        private void radGridView1_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            statusPanelRecords.Text = $"Total Records : {radGridView1.Rows.Count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeData("[STATUS ORDER] = 'N/A'");
        }

        void InitializeData(string Value = "")
        {
            if (Value == string.Empty)
            {
                radGridView1.DataSource = _datatable;
                radGridView1.Update();
                return;
            }
            DataView dv = new DataView(_datatable);
            dv.RowFilter = "[STATUS ORDER] = 'PAID'";
            this._datatable.Select(Value);
            radGridView1.DataSource = null;
            radGridView1.DataSource = dv.Table;
            //radGridView1.Update();
            InitGroupData();
        }

        void InitGroupData()
        {
            radGridView1.Columns["IDBLOK"].IsVisible = false;
            radGridView1.Columns["IDUNIT"].IsVisible = false;
            radGridView1.Columns["KAVLING"].IsVisible = false;
            radGridView1.Columns["NOMOR"].IsVisible = false;
            radGridView1.Columns["TANGGAL ORDER"].IsVisible = false;
            //radGridView1.Columns["TANGGAL ORDER"].FormatString = "{0:dd MMM yyyy}";
            radGridView1.Columns["TANGGAL ORDER"].TextAlignment = ContentAlignment.MiddleRight;
            radGridView1.Columns["ORDERID"].FormatString = "#{0}";

            radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
            radGridView1.MasterTemplate.ShowTotals = true;
            //GridViewSummaryItem summaryItem = new GridViewSummaryItem("ORDERID", "Total {0} Unit", GridAggregateFunction.Count);
            //GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            //summaryRowItem.Add(summaryItem);
            //this.radGridView1.SummaryRowsTop.Add(summaryRowItem);

            GroupDescriptor grupBLOK = new GroupDescriptor();
            GroupDescriptor grupTanggalOrder = new GroupDescriptor();
            grupTanggalOrder.GroupNames.Add("Nomor Pengajuan", ListSortDirection.Ascending);
            grupTanggalOrder.Aggregates.Add("First(`TANGGAL ORDER`)");
            grupTanggalOrder.Aggregates.Add("Count(`ORDERID`)");
            grupTanggalOrder.Format = "Kategori Pengajuan: {1} Tanggal:{2: dd MMM yyyy} Total: {3} Unit";
            grupBLOK.GroupNames.Add("KAVLING", ListSortDirection.Ascending);
            grupBLOK.Aggregates.Add("Count(`BLOK - NOMOR`)");
            grupBLOK.Format = "Kategori Kavling: {1} SubTotal: {2} Unit";

            this.radGridView1.GroupDescriptors.Add(grupTanggalOrder);
            this.radGridView1.GroupDescriptors.Add(grupBLOK);

            radGridView1.ShowGroupPanel = false;
            radGridView1.AutoExpandGroups = true;
            radGridView1.EnableFiltering = false;
            columns = new GridViewColumnCollection(radGridView1.MasterTemplate);
            foreach (GridViewColumn col in radGridView1.MasterTemplate.Columns)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = col.Name;
                radDropDownList1.Items.Add(item);
            }

            radGridView1.Update();
        }

    }
}
