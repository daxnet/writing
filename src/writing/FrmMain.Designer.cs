namespace writing
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.ribbonMenu = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonQATButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.rbTabView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.rbTabHome = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.InDesignHelperMode = true;
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.kryptonRibbonQATButton1});
            this.ribbonMenu.RibbonAppButton.AppButtonImage = null;
            this.ribbonMenu.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.rbTabHome,
            this.rbTabView});
            this.ribbonMenu.SelectedContext = null;
            this.ribbonMenu.SelectedTab = this.rbTabHome;
            this.ribbonMenu.Size = new System.Drawing.Size(877, 143);
            this.ribbonMenu.TabIndex = 0;
            // 
            // rbTabView
            // 
            this.rbTabView.KeyTip = "V";
            this.rbTabView.Text = "View";
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Location = new System.Drawing.Point(0, 614);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(877, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "108BEFB3C35741484F9AC419A36FB614";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage3.Text = "kryptonPage3";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "46BDE6F2144C45EB14A781D8BA71EC36";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage4.Text = "kryptonPage4";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "ED586A25BA1B4EF10C8DC943507E419A";
            // 
            // rbTabHome
            // 
            this.rbTabHome.KeyTip = "H";
            this.rbTabHome.Text = "Home";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 636);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Ribbon.KryptonRibbon ribbonMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab rbTabView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton kryptonRibbonQATButton1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab rbTabHome;
    }
}