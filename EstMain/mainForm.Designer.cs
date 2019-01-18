namespace EstMain
{
    partial class mainForm
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
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItemMainMenu = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuOpenDatabase = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemReports = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemOrderKWH = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 352);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(815, 26);
            this.radStatusStrip1.TabIndex = 1;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemMainMenu,
            this.radMenuItemReports});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(815, 20);
            this.radMenu1.TabIndex = 2;
            // 
            // radMenuItemMainMenu
            // 
            this.radMenuItemMainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuOpenDatabase});
            this.radMenuItemMainMenu.Name = "radMenuItemMainMenu";
            this.radMenuItemMainMenu.ShowArrow = false;
            this.radMenuItemMainMenu.Text = "&Menu";
            // 
            // radMenuOpenDatabase
            // 
            this.radMenuOpenDatabase.Name = "radMenuOpenDatabase";
            this.radMenuOpenDatabase.Text = "Open &Database";
            this.radMenuOpenDatabase.Click += new System.EventHandler(this.radMenuOpenDatabase_Click);
            // 
            // radMenuItemReports
            // 
            this.radMenuItemReports.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemOrderKWH});
            this.radMenuItemReports.Name = "radMenuItemReports";
            this.radMenuItemReports.ShowArrow = false;
            this.radMenuItemReports.Text = "&Reports";
            // 
            // radMenuItemOrderKWH
            // 
            this.radMenuItemOrderKWH.Name = "radMenuItemOrderKWH";
            this.radMenuItemOrderKWH.Text = "Report Order ME";
            this.radMenuItemOrderKWH.Click += new System.EventHandler(this.radMenuItemOrderKWH_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 378);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radStatusStrip1);
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Estate App Database";
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemMainMenu;
        private Telerik.WinControls.UI.RadMenuItem radMenuOpenDatabase;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemReports;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemOrderKWH;
    }
}

