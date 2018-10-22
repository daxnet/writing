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
            this.rbTabHome = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.rbTabView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.mainSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kryptonHeaderGroupOutline = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroupOutlineCollapse = new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.htmlEditor1 = new Writing.Core.Controls.HtmlEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel1)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel2)).BeginInit();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupOutline.Panel)).BeginInit();
            this.kryptonHeaderGroupOutline.SuspendLayout();
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
            this.ribbonMenu.SelectedTab = this.rbTabHome;
            this.ribbonMenu.Size = new System.Drawing.Size(877, 115);
            this.ribbonMenu.TabIndex = 0;
            // 
            // rbTabHome
            // 
            this.rbTabHome.KeyTip = "H";
            this.rbTabHome.Text = "Home";
            // 
            // rbTabView
            // 
            this.rbTabView.KeyTip = "V";
            this.rbTabView.Text = "View";
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
            // mainSplitContainer
            // 
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 115);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.kryptonHeaderGroupOutline);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.htmlEditor1);
            this.mainSplitContainer.Size = new System.Drawing.Size(877, 499);
            this.mainSplitContainer.SplitterDistance = 292;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // kryptonHeaderGroupOutline
            // 
            this.kryptonHeaderGroupOutline.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroupOutlineCollapse});
            this.kryptonHeaderGroupOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeaderGroupOutline.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroupOutline.Name = "kryptonHeaderGroupOutline";
            this.kryptonHeaderGroupOutline.Size = new System.Drawing.Size(292, 499);
            this.kryptonHeaderGroupOutline.TabIndex = 0;
            // 
            // buttonSpecHeaderGroupOutlineCollapse
            // 
            this.buttonSpecHeaderGroupOutlineCollapse.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft;
            this.buttonSpecHeaderGroupOutlineCollapse.UniqueName = "A10BECB59DFC4BA303AEBD0F692D0DD9";
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditor1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.Size = new System.Drawing.Size(580, 499);
            this.htmlEditor1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 636);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel1)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel2)).EndInit();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupOutline.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupOutline)).EndInit();
            this.kryptonHeaderGroupOutline.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer mainSplitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroupOutline;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroupOutlineCollapse;
        private Writing.Core.Controls.HtmlEditor htmlEditor1;
    }
}