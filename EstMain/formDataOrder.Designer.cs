namespace EstMain
{
    partial class formDataOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.statusPanelRecords = new Telerik.WinControls.UI.RadStatusBarPanelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radStatusBarPanelElement1 = new Telerik.WinControls.UI.RadStatusBarPanelElement();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(0, 47);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(659, 243);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.radGridView1_DataBindingComplete);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.statusPanelRecords,
            this.commandBarSeparator1,
            this.radStatusBarPanelElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 290);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(659, 26);
            this.radStatusStrip1.TabIndex = 1;
            // 
            // statusPanelRecords
            // 
            this.statusPanelRecords.Name = "statusPanelRecords";
            this.radStatusStrip1.SetSpring(this.statusPanelRecords, false);
            this.statusPanelRecords.Text = "Total :                                 ";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.statusPanelRecords.GetChildAt(2))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.statusPanelRecords.GetChildAt(2))).Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Text = "";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radStatusBarPanelElement1
            // 
            this.radStatusBarPanelElement1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.radStatusBarPanelElement1.Name = "radStatusBarPanelElement1";
            this.radStatusBarPanelElement1.Padding = new System.Windows.Forms.Padding(0);
            this.radStatusStrip1.SetSpring(this.radStatusBarPanelElement1, true);
            this.radStatusBarPanelElement1.Text = "";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(12, 12);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.NullText = "Data Kolom";
            this.radDropDownList1.Size = new System.Drawing.Size(159, 20);
            this.radDropDownList1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(196, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 24);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // formDataOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 316);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radStatusStrip1);
            this.Name = "formDataOrder";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "formDataOrder";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadStatusBarPanelElement statusPanelRecords;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadStatusBarPanelElement radStatusBarPanelElement1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadButton btnRefresh;
    }
}