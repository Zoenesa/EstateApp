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

        Commons.LoadTable InitData;

        public formDataOrder(DataTable table)
        {
            InitializeComponent();
            this.Text = "View Data Pengajuan KWH";
            this.radGridView1.EnableFiltering = false;
            this.radGridView1.GroupSummaryEvaluate += RadGridView1_GroupSummaryEvaluate;
            this._datatable = table;
            InitializeData();
        }

        public formDataOrder(Commons.LoadTable InitTable)
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            this.InitData = InitTable;
            InitData.LoadQuery();
            InitData.Data_Table.TableName = "view_orderkwhsimple";
            DataTable dt = new DataTable();
            dt = InitTable.Modul.OpenTable(@"SELECT DISTINCT statusorderkwh.statusname AS `STATUS ORDER`
                                            from orderkwh
                                            JOIN statusorderkwh ON orderkwh.`Status` = statusorderkwh.statuscode
                                            ORDER BY statusorderkwh.statuscode");
            dt.TableName = "statusorderkwh";
            ds.Tables.Add(InitTable.Data_Table);
            ds.Tables.Add(dt);
            controlData1.SetData(ds);
            controlData1.btnApply.Click += BtnApply_Click;
            controlData1.btnGroupBy.Click += BtnGroupBy_Click;
            this.radGridView1.DataSource = InitData.Data_Table;
            InitGroupData();
        }

        private void BtnGroupBy_Click(object sender, EventArgs e)
        {
            ApplyGroup();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            InitData.QueryCondition = $"WHERE `{controlData1.ColumnName??"STATUS ORDER"}` = '{controlData1.ConditionValue}'";
            InitData.Refresh();
            radGridView1.DataSource = InitData.Data_Table;
        }

        private void RadGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
        }

        private void radGridView1_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            statusPanelRecords.Text = $"Total Records : {radGridView1.Rows.Count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitData.QueryCondition = "WHERE `STATUS ORDER` = 'PAID'";
            InitData.Refresh();
            radGridView1.DataSource = InitData.Data_Table;
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
            radGridView1.Update();
            InitGroupData();
        }

        void ApplyGroup()
        {
            string[] grups = controlData1.CheckedColumns;
            if (grups == null || grups.Length == 0)
            {
                InitGroupData();
                return;
            }
                this.radGridView1.GroupDescriptors.Clear();
            for (int i = 0; i < grups.Length; i++)
            {
                GroupDescriptor grup = new GroupDescriptor();
                if (grups[i] == "Nomor Pengajuan")
                {
                    grup.GroupNames.Add(grups[i], ListSortDirection.Ascending);
                    grup.Aggregates.Add($"First(`TANGGAL ORDER`)");
                    grup.Aggregates.Add("Count(`ORDERID`)");
                    grup.Format = "Sub Pengajuan: {1} Tanggal: {2:dd MMM yyyy} Total: {3} Unit";
                }
                else
                {
                    grup.GroupNames.Add(grups[i], ListSortDirection.Ascending);
                    grup.Aggregates.Add($"Count(`{grups[i]}`)");
                    grup.Format = "Sub " + grups[i] + ": {1} Subtotal: {2} Unit";
                }
                this.radGridView1.GroupDescriptors.Add(grup);
            }
        }

        void InitGroupData()
        {
            this.radGridView1.GroupDescriptors.Clear();
            radGridView1.Columns["IDBLOK"].IsVisible = false;
            radGridView1.Columns["IDUNIT"].IsVisible = false;
            radGridView1.Columns["KAVLING"].IsVisible = false;
            radGridView1.Columns["NOMOR"].IsVisible = false;
            radGridView1.Columns["TANGGAL ORDER"].IsVisible = false;
            radGridView1.Columns["TANGGAL ORDER"].TextAlignment = ContentAlignment.MiddleRight;
            radGridView1.Columns["ORDERID"].FormatString = "#{0}";

            radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
            radGridView1.MasterTemplate.ShowTotals = true;

            GroupDescriptor grupBLOK = new GroupDescriptor();
            GroupDescriptor grupTanggalOrder = new GroupDescriptor();
            grupTanggalOrder.GroupNames.Add("Nomor Pengajuan", ListSortDirection.Ascending);
            grupTanggalOrder.Aggregates.Add("First(`TANGGAL ORDER`)");
            grupTanggalOrder.Aggregates.Add("Count(`ORDERID`)");
            grupTanggalOrder.Format = "Sub Nomor Pengajuan: {1} Tanggal:{2: dd MMM yyyy} Total: {3} Unit";
            grupBLOK.GroupNames.Add("KAVLING", ListSortDirection.Ascending);
            grupBLOK.Aggregates.Add("Count(`BLOK - NOMOR`)");
            grupBLOK.Format = "Sub Kavling: {1} SubTotal: {2} Unit";

            this.radGridView1.GroupDescriptors.Add(grupTanggalOrder);
            this.radGridView1.GroupDescriptors.Add(grupBLOK);

            radGridView1.ShowGroupPanel = false;
            radGridView1.AutoExpandGroups = true;
            radGridView1.EnableFiltering = false;
            radGridView1.Update();
        }

    }
}
