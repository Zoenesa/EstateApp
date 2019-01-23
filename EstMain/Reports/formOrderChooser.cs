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

namespace EstMain.Reports
{
    public partial class formOrderChooser : RadForm
    {
        public formOrderChooser()
        {
            InitializeComponent();
        }

        public formOrderChooser(List<string> OrderValues)
        {
            InitializeComponent();
            this._OrderValues = OrderValues;
            GetDataoRder();
        }

        public formOrderChooser(DataTable DataOrderValues)
        {
            InitializeComponent();
            this._DataOrderValues = DataOrderValues;
            GetDataoRder();
        }

        private DataTable _DataOrderValues;

        public List<string> FilterValues { get { return (from s in chkDropDownOrderValue.CheckedItems select s.Value.ToString()).ToList(); } }

        private List<string> _OrderValues;

        void GetDataoRder()
        {
            chkDropDownOrderValue.Items.Clear();
            chkDropDownOrderValue.DataSource = this._DataOrderValues;
            chkDropDownOrderValue.DisplayMember = "statusname";
            chkDropDownOrderValue.ValueMember = "statuscode";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radCheckBoxMunculkanSemuaData.Checked)
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                if (FilterValues.Count == chkDropDownOrderValue.Items.Count)
                {
                    this.DialogResult = DialogResult.No;
                }
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
