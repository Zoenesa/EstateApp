namespace EstMain.Controls
{
    partial class controlDataTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.datagrid = new Telerik.WinControls.UI.RadGridView();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid.MasterTemplate)).BeginInit();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.tableLayout.SetColumnSpan(this.datagrid, 3);
            this.datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.datagrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(540, 176);
            this.datagrid.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Controls.Add(this.datagrid, 0, 0);
            this.tableLayout.Controls.Add(this.labelTotalRecords, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayout.Size = new System.Drawing.Size(546, 211);
            this.tableLayout.TabIndex = 1;
            // 
            // labelTotalRecords
            // 
            this.labelTotalRecords.AutoSize = true;
            this.labelTotalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalRecords.Location = new System.Drawing.Point(4, 186);
            this.labelTotalRecords.Margin = new System.Windows.Forms.Padding(4);
            this.labelTotalRecords.Name = "labelTotalRecords";
            this.labelTotalRecords.Size = new System.Drawing.Size(173, 21);
            this.labelTotalRecords.TabIndex = 1;
            this.labelTotalRecords.Text = "Total Records:";
            // 
            // controlDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayout);
            this.Name = "controlDataTable";
            this.Size = new System.Drawing.Size(546, 211);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView datagrid;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label labelTotalRecords;
    }
}
