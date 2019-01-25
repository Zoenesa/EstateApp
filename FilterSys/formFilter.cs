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

namespace FilterSys
{
    public partial class formFilter : RadForm
    {

        public DataTable Table { get { return _Table; } }

        private DataTable _Table;

        public string Query { get { return _Query; } }

        private string _Query;

        public string Condition { get { return _Condition; } }

        private string _Condition;

        public formFilter()
        {
            InitializeComponent();
        }

        public formFilter(DataTable dataTable)
        {
            this._Table = dataTable;
        }
    }
}
