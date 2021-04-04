
namespace WereDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonProduct = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonContragents = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonDocuments = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonCreateDocument = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barButtonItem);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonProduct,
            this.barButtonContragents,
            this.barButtonDocuments,
            this.barButtonCreateDocument});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1064, 165);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem
            // 
            this.barButtonItem.Caption = "Относно";
            this.barButtonItem.Id = 5;
            this.barButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem.ImageOptions.Image")));
            this.barButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem.ImageOptions.LargeImage")));
            this.barButtonItem.Name = "barButtonItem";
            this.barButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonProduct
            // 
            this.barButtonProduct.Caption = "Продукти";
            this.barButtonProduct.Id = 1;
            this.barButtonProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonProduct.ImageOptions.SvgImage")));
            this.barButtonProduct.Name = "barButtonProduct";
            this.barButtonProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonProduct_ItemClick);
            // 
            // barButtonContragents
            // 
            this.barButtonContragents.Caption = "Контрагенти";
            this.barButtonContragents.Id = 2;
            this.barButtonContragents.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonContragents.ImageOptions.SvgImage")));
            this.barButtonContragents.Name = "barButtonContragents";
            this.barButtonContragents.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonContragents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonContragents_ItemClick);
            // 
            // barButtonDocuments
            // 
            this.barButtonDocuments.Caption = "Документи";
            this.barButtonDocuments.Id = 3;
            this.barButtonDocuments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDocuments.ImageOptions.SvgImage")));
            this.barButtonDocuments.Name = "barButtonDocuments";
            this.barButtonDocuments.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonDocuments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDocuments_ItemClick);
            // 
            // barButtonCreateDocument
            // 
            this.barButtonCreateDocument.Caption = "Създаване на документ";
            this.barButtonCreateDocument.Id = 4;
            this.barButtonCreateDocument.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonCreateDocument.ImageOptions.SvgImage")));
            this.barButtonCreateDocument.Name = "barButtonCreateDocument";
            this.barButtonCreateDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonCreateDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCreateDocument_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMenu});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Меню";
            // 
            // ribbonPageGroupMenu
            // 
            this.ribbonPageGroupMenu.ItemLinks.Add(this.barButtonProduct);
            this.ribbonPageGroupMenu.ItemLinks.Add(this.barButtonContragents);
            this.ribbonPageGroupMenu.ItemLinks.Add(this.barButtonDocuments);
            this.ribbonPageGroupMenu.ItemLinks.Add(this.barButtonCreateDocument);
            this.ribbonPageGroupMenu.Name = "ribbonPageGroupMenu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 694);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1064, 27);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pictureEdit1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 165);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1064, 529);
            this.mainPanel.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(1060, 525);
            this.pictureEdit1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Were Desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarCheckItem barButtonProduct;
        private DevExpress.XtraBars.BarCheckItem barButtonContragents;
        private DevExpress.XtraBars.BarCheckItem barButtonDocuments;
        private DevExpress.XtraBars.BarCheckItem barButtonCreateDocument;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}