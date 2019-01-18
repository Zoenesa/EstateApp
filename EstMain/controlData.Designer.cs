namespace EstMain
{
    partial class controlData
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
            this.btnExpand = new Telerik.WinControls.UI.RadButton();
            this.dropDownColumns = new Telerik.WinControls.UI.RadDropDownList();
            this.dropDownStatusOrder = new Telerik.WinControls.UI.RadDropDownList();
            this.chkDropDownColumns = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.btnApply = new Telerik.WinControls.UI.RadButton();
            this.btnGroupBy = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownStatusOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDropDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroupBy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.Location = new System.Drawing.Point(474, 73);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(110, 24);
            this.btnExpand.TabIndex = 0;
            this.btnExpand.Text = "Expand";
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // dropDownColumns
            // 
            this.dropDownColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dropDownColumns.Location = new System.Drawing.Point(29, 19);
            this.dropDownColumns.Name = "dropDownColumns";
            this.dropDownColumns.Size = new System.Drawing.Size(221, 20);
            this.dropDownColumns.TabIndex = 1;
            this.dropDownColumns.Text = "Columns";
            this.dropDownColumns.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dropDownColumns_SelectedIndexChanged);
            // 
            // dropDownStatusOrder
            // 
            this.dropDownStatusOrder.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dropDownStatusOrder.Location = new System.Drawing.Point(322, 19);
            this.dropDownStatusOrder.Name = "dropDownStatusOrder";
            this.dropDownStatusOrder.Size = new System.Drawing.Size(125, 20);
            this.dropDownStatusOrder.TabIndex = 2;
            this.dropDownStatusOrder.Text = "Status Order";
            this.dropDownStatusOrder.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dropDownStatusOrder_SelectedIndexChanged);
            // 
            // chkDropDownColumns
            // 
            this.chkDropDownColumns.Location = new System.Drawing.Point(28, 56);
            this.chkDropDownColumns.Name = "chkDropDownColumns";
            this.chkDropDownColumns.Size = new System.Drawing.Size(296, 20);
            this.chkDropDownColumns.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(474, 19);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 24);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(337, 56);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(110, 24);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "Apply Group";
            // 
            // controlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.chkDropDownColumns);
            this.Controls.Add(this.dropDownStatusOrder);
            this.Controls.Add(this.dropDownColumns);
            this.Controls.Add(this.btnExpand);
            this.Name = "controlData";
            this.Size = new System.Drawing.Size(587, 100);
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownStatusOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDropDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroupBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnExpand;
        private Telerik.WinControls.UI.RadDropDownList dropDownColumns;
        private Telerik.WinControls.UI.RadDropDownList dropDownStatusOrder;
        private Telerik.WinControls.UI.RadCheckedDropDownList chkDropDownColumns;
        internal Telerik.WinControls.UI.RadButton btnApply;
        internal Telerik.WinControls.UI.RadButton btnGroupBy;
    }
}
