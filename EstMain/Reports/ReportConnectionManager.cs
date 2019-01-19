using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Reporting;

namespace EstMain
{
    public class ReportConnectionManager
    {
        readonly string connectionString;
        readonly string SelectCommand;

        public ReportConnectionManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ReportConnectionManager(string connectionString, string Command)
        {
            this.connectionString = connectionString;
            this.SelectCommand = Command;
        }

        public ReportSource UpdateReportSource(ReportSource sourceReportSource)
        {
            if (sourceReportSource is UriReportSource)
            {
                var uriReportSource = (UriReportSource)sourceReportSource;
                // unpackage TRDP report
                // http://docs.telerik.com/reporting/report-packaging-trdp#unpackaging
                var reportInstance = UnpackageReport(uriReportSource);
                // or deserialize TRDX report(legacy format)
                // http://docs.telerik.com/reporting/programmatic-xml-serialization#deserialize-report-definition-from-xml-file
                // var reportInstance = DeserializeReport(uriReportSource);
                ValidateReportSource(uriReportSource.Uri);
                this.SetConnectionString(reportInstance);
                return CreateInstanceReportSource(reportInstance, uriReportSource);
            }

            if (sourceReportSource is XmlReportSource)
            {
                var xml = (XmlReportSource)sourceReportSource;
                ValidateReportSource(xml.Xml);
                var reportInstance = this.DeserializeReport(xml);
                this.SetConnectionString(reportInstance);
                return CreateInstanceReportSource(reportInstance, xml);
            }

            if (sourceReportSource is InstanceReportSource)
            {
                var instanceReportSource = (InstanceReportSource)sourceReportSource;
                this.SetConnectionString((ReportItemBase)instanceReportSource.ReportDocument);
                return instanceReportSource;
            }

            if (sourceReportSource is TypeReportSource)
            {
                var typeReportSource = (TypeReportSource)sourceReportSource;
                var typeName = typeReportSource.TypeName;
                ValidateReportSource(typeName);
                var reportType = Type.GetType(typeName);
                var reportInstance = (Telerik.Reporting.Report)Activator.CreateInstance(reportType);
                this.SetConnectionString((ReportItemBase)reportInstance);
                return CreateInstanceReportSource(reportInstance, typeReportSource);
            }

            throw new NotImplementedException("Handler for the used ReportSource type is not implemented.");
        }

        ReportSource CreateInstanceReportSource(IReportDocument report, ReportSource originalReportSource)
        {
            var instanceReportSource = new InstanceReportSource { ReportDocument = report };
            instanceReportSource.Parameters.AddRange(originalReportSource.Parameters);
            return instanceReportSource;
        }

        void ValidateReportSource(string value)
        {
            if (value.Trim().StartsWith("="))
            {
                throw new InvalidOperationException("Expressions for ReportSource are not supported when changing the connection string dynamically");
            }
        }

        Telerik.Reporting.Report UnpackageReport(UriReportSource uriReportSource)
        {
            var reportPackager = new ReportPackager();
            using (var sourceStream = System.IO.File.OpenRead(uriReportSource.Uri))
            {
                var report = (Telerik.Reporting.Report)reportPackager.UnpackageDocument(sourceStream);
                return report;
            }
        }

        Telerik.Reporting.Report DeserializeReport(UriReportSource uriReportSource)
        {
            var settings = new System.Xml.XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            using (var xmlReader = System.Xml.XmlReader.Create(uriReportSource.Uri, settings))
            {
                var xmlSerializer = new Telerik.Reporting.XmlSerialization.ReportXmlSerializer();
                var report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
                return report;
            }
        }

        Telerik.Reporting.Report DeserializeReport(XmlReportSource xmlReportSource)
        {
            var settings = new System.Xml.XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            var textReader = new System.IO.StringReader(xmlReportSource.Xml);
            using (var xmlReader = System.Xml.XmlReader.Create(textReader, settings))
            {
                var xmlSerializer = new Telerik.Reporting.XmlSerialization.ReportXmlSerializer();
                var report = (Telerik.Reporting.Report)xmlSerializer.Deserialize(xmlReader);
                return report;
            }
        }

        void SetConnectionString(ReportItemBase reportItemBase)
        {
            if (reportItemBase.Items.Count < 1)
                return;

            if (reportItemBase is Telerik.Reporting.Report)
            {
                var report = (Telerik.Reporting.Report)reportItemBase;

                if (report.DataSource is SqlDataSource)
                {
                    var sqlDataSource = (SqlDataSource)report.DataSource;
                    sqlDataSource.ConnectionString = connectionString;
                }
                foreach (var parameter in report.ReportParameters)
                {
                    if (parameter.AvailableValues.DataSource is SqlDataSource)
                    {
                        var sqlDataSource = (SqlDataSource)parameter.AvailableValues.DataSource;
                        sqlDataSource.ConnectionString = connectionString;
                    }
                }
            }

            if (reportItemBase is Table)
            {
                var itemTable = (Table)reportItemBase;
                if (itemTable.DataSource is SqlDataSource)
                {
                    var sqlsrc = (SqlDataSource)itemTable.DataSource;
                    sqlsrc.ConnectionString = connectionString;
                    sqlsrc.ProviderName = "Mysql.Data.MysqlClient";
                    if (!string.IsNullOrEmpty(this.SelectCommand))
                    {
                        sqlsrc.SelectCommand = this.SelectCommand;
                    }
                    //itemTable.DataSource = sqlsrc;
                    //return;
                }
            }

            foreach (var item in reportItemBase.Items)
            {
                //recursively set the connection string to the items from the Items collection
                SetConnectionString(item);

                //set the drillthrough report connection strings
                var drillThroughAction = item.Action as NavigateToReportAction;
                if (null != drillThroughAction)
                {
                    var updatedReportInstance = this.UpdateReportSource(drillThroughAction.ReportSource);
                    drillThroughAction.ReportSource = updatedReportInstance;
                }

                if (item is SubReport)
                {
                    var subReport = (SubReport)item;
                    subReport.ReportSource = this.UpdateReportSource(subReport.ReportSource);
                    continue;
                }

                //Covers all data items(Crosstab, Table, List, Graph, Map and Chart)
                if (item is DataItem)
                {
                    var dataItem = (DataItem)item;
                    if (dataItem.DataSource is SqlDataSource)
                    {
                        var sqlDataSource = (SqlDataSource)dataItem.DataSource;
                        sqlDataSource.ConnectionString = connectionString;
                        continue;
                    }
                }
            }
        }

        public void SetItemValue(ReportSource reportItemBase, string ReportItem, string value)
        {
            InstanceReportSource instance = (InstanceReportSource)reportItemBase;
            Telerik.Reporting.Report report = (Telerik.Reporting.Report)instance.ReportDocument;
            TextBox txtBox = report.Items.Find(ReportItem, true)[0] as TextBox;
            txtBox.Value = value;
        }
    }
}