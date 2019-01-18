using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Db;

namespace EstMain
{
    public static class Commons
    {

        public class LoadTable
        {
            public LoadTable()
            {

            }

            public LoadTable(mdl Modul)
            {
                this._Modul = Modul;
            }

            public mdl Modul { get { return _Modul; } }

            private mdl _Modul { get; set; }

            public string QuerySelect { get; set; }

            public string QueryCondition { get; set; }

            public string QuerySortBy { get; set; }

            public string QueryGroupBy { get; set; }

            public DataTable Data_Table { get; private set; }

            public void LoadQuery()
            {
                this.Data_Table = LoadDataTable();
            }

            private DataTable LoadDataTable()
            {
                DataTable dt = new DataTable();
                string command = string.Format("{0} {1} {2} {3}", this.QuerySelect, this.QueryCondition, this.QueryGroupBy, this.QuerySortBy);
                try
                {
                    dt = this.Modul.OpenTable(command);
                }
                catch (Exception)
                {
                    throw;
                }
                return dt;
            }

            public void Refresh()
            {
                this.Data_Table = LoadDataTable();
            }
        }
    }
}