using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EstMain
{
    public partial class controlData : UserControl
    {
        public controlData()
        {
            InitializeComponent();
            this.expand = false;
            ExpandControl();
            //btnApply.Click += btnApply_Click;
            init();
        }

        bool expand { get; set; } = false;

        [Browsable(false)]
        public DataTable Data_Table { get { return table; } }

        DataTable table { get; set; }

        [Browsable(false)]
        public DataSet Data_Set { get { return ds; } }

        private DataSet ds { get; set; }

        [Browsable(false)]
        public string ColumnName
        {
            get
            {
                if (dropDownColumns.SelectedIndex == -1)
                {
                    return "";
                }
                return dropDownColumns.SelectedItem.Text;
            }
            private set { value = colName; }
        }

        [Browsable(false)]
        public string ConditionValue
        { get
            {
                if (dropDownStatusOrder.SelectedIndex == -1)
                {
                    return "";
                }
                return dropDownStatusOrder.SelectedItem.Text;
            }
            private set { value = conditionvalue; }
        }

        [Browsable(false)]
        public string[] CheckedColumns
        {
            get
            {
                string[] t = new string[chkDropDownColumns.CheckedItems.Count];
                for (int i = 0; i < chkDropDownColumns.CheckedItems.Count; i++)
                {
                    t[i] = chkDropDownColumns.CheckedItems[i].Text;
                }
                return t.Length == 0 ? null : t;
            }
        }

        string colName; string conditionvalue;

        void ExpandControl()
        {
            if (!expand)
            {
                expand = true;
                dropDownStatusOrder.Visible = false;
                dropDownColumns.Visible = false;
                btnApply.Visible = false;
                this.btnExpand.Text = "Filter";
                this.Height = 30;
            }
            else
            {
                expand = false;
                this.btnExpand.Text = "Hide";
                dropDownStatusOrder.Visible = true;
                dropDownColumns.Visible = true;
                btnApply.Visible = true;
                this.Height = 130;
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            ExpandControl();
        }

        void init()
        {
            if (Data_Set != null)
            {
                foreach (DataColumn col in Data_Set.Tables["view_orderkwhsimple"].Columns)
                {
                    RadCheckedListDataItem chkItem = new RadCheckedListDataItem(col.ColumnName, false);
                    chkDropDownColumns.Items.Add(chkItem);
                    RadListDataItem item = new RadListDataItem(col.ColumnName);
                    dropDownColumns.Items.Add(item);
                }

                foreach (DataRow row in Data_Set.Tables["statusorderkwh"].Rows)
                {
                    dropDownStatusOrder.Items.Add(new RadListDataItem(row.ItemArray[0].ToString()));
                }
            }
        }

        public void SetData(DataSet dataSet)
        {
            this.ds = dataSet;
            init();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //_condition = $"WHERE {dropDownColumns.SelectedItem.Text} = '{dropDownStatusOrder.SelectedItem.Text}'";
        }

        private void dropDownColumns_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            colName = dropDownColumns.Items[e.Position].Text;
        }

        private void dropDownStatusOrder_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            conditionvalue = dropDownStatusOrder.Items[e.Position].Text;
        }
    }
}
