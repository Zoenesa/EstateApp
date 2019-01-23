namespace EstMain.Reports
{
    partial class formOrderChooser
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
            this.grupFilterReportStatusOrder = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutOrder = new System.Windows.Forms.TableLayoutPanel();
            this.chkDropDownOrderValue = new Telerik.WinControls.UI.RadCheckedDropDownList();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxMunculkanSemuaData = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grupFilterReportStatusOrder)).BeginInit();
            this.grupFilterReportStatusOrder.SuspendLayout();
            this.tableLayoutOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDropDownOrderValue)).BeginInit();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMunculkanSemuaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grupFilterReportStatusOrder
            // 
            this.grupFilterReportStatusOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.tableLayout.SetColumnSpan(this.grupFilterReportStatusOrder, 3);
            this.grupFilterReportStatusOrder.Controls.Add(this.tableLayoutOrder);
            this.grupFilterReportStatusOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupFilterReportStatusOrder.HeaderText = "Filter Report berdasarkan Status Order";
            this.grupFilterReportStatusOrder.Location = new System.Drawing.Point(3, 3);
            this.grupFilterReportStatusOrder.Name = "grupFilterReportStatusOrder";
            this.grupFilterReportStatusOrder.Size = new System.Drawing.Size(552, 65);
            this.grupFilterReportStatusOrder.TabIndex = 0;
            this.grupFilterReportStatusOrder.Text = "Filter Report berdasarkan Status Order";
            // 
            // tableLayoutOrder
            // 
            this.tableLayoutOrder.ColumnCount = 3;
            this.tableLayoutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutOrder.Controls.Add(this.chkDropDownOrderValue, 1, 0);
            this.tableLayoutOrder.Controls.Add(this.labelStatusValue, 0, 0);
            this.tableLayoutOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOrder.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutOrder.Name = "tableLayoutOrder";
            this.tableLayoutOrder.RowCount = 2;
            this.tableLayoutOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOrder.Size = new System.Drawing.Size(548, 45);
            this.tableLayoutOrder.TabIndex = 1;
            // 
            // chkDropDownOrderValue
            // 
            this.chkDropDownOrderValue.AutoSize = false;
            this.chkDropDownOrderValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDropDownOrderValue.Location = new System.Drawing.Point(103, 3);
            this.chkDropDownOrderValue.Name = "chkDropDownOrderValue";
            this.chkDropDownOrderValue.NullText = "Order Values";
            this.chkDropDownOrderValue.Size = new System.Drawing.Size(352, 23);
            this.chkDropDownOrderValue.TabIndex = 0;
            ((Telerik.WinControls.UI.RadCheckedDropDownListElement)(this.chkDropDownOrderValue.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.TextBoxWrapPanel)(this.chkDropDownOrderValue.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusValue.Location = new System.Drawing.Point(3, 3);
            this.labelStatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(94, 23);
            this.labelStatusValue.TabIndex = 1;
            this.labelStatusValue.Text = "Status Value:";
            this.labelStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.grupFilterReportStatusOrder, 0, 0);
            this.tableLayout.Controls.Add(this.btnOK, 0, 2);
            this.tableLayout.Controls.Add(this.btnCancel, 2, 2);
            this.tableLayout.Controls.Add(this.radCheckBoxMunculkanSemuaData, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayout.Size = new System.Drawing.Size(558, 129);
            this.tableLayout.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Location = new System.Drawing.Point(3, 103);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(270, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(284, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(271, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            // 
            // radCheckBoxMunculkanSemuaData
            // 
            this.radCheckBoxMunculkanSemuaData.AutoSize = false;
            this.radCheckBoxMunculkanSemuaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCheckBoxMunculkanSemuaData.Location = new System.Drawing.Point(3, 74);
            this.radCheckBoxMunculkanSemuaData.Name = "radCheckBoxMunculkanSemuaData";
            this.radCheckBoxMunculkanSemuaData.Size = new System.Drawing.Size(270, 23);
            this.radCheckBoxMunculkanSemuaData.TabIndex = 3;
            this.radCheckBoxMunculkanSemuaData.Text = "Munculkan semua &Data";
            // 
            // formOrderChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 129);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formOrderChooser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "formOrderChooser";
            ((System.ComponentModel.ISupportInitialize)(this.grupFilterReportStatusOrder)).EndInit();
            this.grupFilterReportStatusOrder.ResumeLayout(false);
            this.tableLayoutOrder.ResumeLayout(false);
            this.tableLayoutOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDropDownOrderValue)).EndInit();
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxMunculkanSemuaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox grupFilterReportStatusOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private Telerik.WinControls.UI.RadButton btnOK;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutOrder;
        private Telerik.WinControls.UI.RadCheckedDropDownList chkDropDownOrderValue;
        private System.Windows.Forms.Label labelStatusValue;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxMunculkanSemuaData;
    }
}