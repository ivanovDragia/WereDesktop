
namespace WereDesktop.Controls
{
    partial class XtraUserControlProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlProducts));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productControlPanel = new DevExpress.XtraEditors.PanelControl();
            this.deleteProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.editProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.addProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.productTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.lotTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.lotGridControl = new DevExpress.XtraGrid.GridControl();
            this.lotBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lotGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lotControlPanel = new DevExpress.XtraEditors.PanelControl();
            this.deleteLotButton = new DevExpress.XtraEditors.SimpleButton();
            this.editLotButton = new DevExpress.XtraEditors.SimpleButton();
            this.addLotButton = new DevExpress.XtraEditors.SimpleButton();
            this.barcodeTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.barcodeGridControl = new DevExpress.XtraGrid.GridControl();
            this.barcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarcodeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deleteBarcodeButton = new DevExpress.XtraEditors.SimpleButton();
            this.editBarcodeButton = new DevExpress.XtraEditors.SimpleButton();
            this.addBarcodeButton = new DevExpress.XtraEditors.SimpleButton();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productControlPanel)).BeginInit();
            this.productControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTabControl)).BeginInit();
            this.productTabControl.SuspendLayout();
            this.lotTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotControlPanel)).BeginInit();
            this.lotControlPanel.SuspendLayout();
            this.barcodeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.productGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.productControlPanel);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.productTabControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(953, 628);
            this.splitContainerControl1.SplitterPosition = 350;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(0, 32);
            this.productGridControl.MainView = this.productGridView;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(953, 318);
            this.productGridControl.TabIndex = 1;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.productGridView});
            this.productGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productGridControl_KeyDown);
            this.productGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productGridControl_MouseDoubleClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WereDesktop.Product);
            // 
            // productGridView
            // 
            this.productGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colQuantity,
            this.colPrice,
            this.colProductNumber});
            this.productGridView.GridControl = this.productGridControl;
            this.productGridView.Name = "productGridView";
            this.productGridView.OptionsBehavior.Editable = false;
            this.productGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.productGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.productGridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Име на продукт";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Количество";
            this.colQuantity.FieldName = "LotSum";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Цена";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 94;
            // 
            // colProductNumber
            // 
            this.colProductNumber.Caption = "Номер на продукт";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.MinWidth = 25;
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.Visible = true;
            this.colProductNumber.VisibleIndex = 3;
            this.colProductNumber.Width = 94;
            // 
            // productControlPanel
            // 
            this.productControlPanel.Controls.Add(this.deleteProductButton);
            this.productControlPanel.Controls.Add(this.editProductButton);
            this.productControlPanel.Controls.Add(this.addProductButton);
            this.productControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productControlPanel.Location = new System.Drawing.Point(0, 0);
            this.productControlPanel.Name = "productControlPanel";
            this.productControlPanel.Size = new System.Drawing.Size(953, 32);
            this.productControlPanel.TabIndex = 0;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteProductButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteProductButton.ImageOptions.Image")));
            this.deleteProductButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteProductButton.Location = new System.Drawing.Point(52, 2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(25, 28);
            this.deleteProductButton.TabIndex = 2;
            this.deleteProductButton.Text = "simpleButton1";
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editProductButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editProductButton.ImageOptions.Image")));
            this.editProductButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editProductButton.Location = new System.Drawing.Point(27, 2);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(25, 28);
            this.editProductButton.TabIndex = 1;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addProductButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.ImageOptions.Image")));
            this.addProductButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addProductButton.Location = new System.Drawing.Point(2, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addProductButton.Size = new System.Drawing.Size(25, 28);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productTabControl
            // 
            this.productTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTabControl.Location = new System.Drawing.Point(0, 0);
            this.productTabControl.Name = "productTabControl";
            this.productTabControl.SelectedTabPage = this.lotTabPage;
            this.productTabControl.Size = new System.Drawing.Size(953, 263);
            this.productTabControl.TabIndex = 0;
            this.productTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.lotTabPage,
            this.barcodeTabPage});
            // 
            // lotTabPage
            // 
            this.lotTabPage.Controls.Add(this.lotGridControl);
            this.lotTabPage.Controls.Add(this.lotControlPanel);
            this.lotTabPage.Name = "lotTabPage";
            this.lotTabPage.Size = new System.Drawing.Size(951, 233);
            this.lotTabPage.Text = "Партиди";
            // 
            // lotGridControl
            // 
            this.lotGridControl.DataSource = this.lotBindingSource1;
            this.lotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotGridControl.Location = new System.Drawing.Point(0, 32);
            this.lotGridControl.MainView = this.lotGridView;
            this.lotGridControl.Name = "lotGridControl";
            this.lotGridControl.Size = new System.Drawing.Size(951, 201);
            this.lotGridControl.TabIndex = 5;
            this.lotGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lotGridView});
            this.lotGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lotGridControl_KeyDown);
            this.lotGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lotGridControl_MouseDoubleClick);
            // 
            // lotBindingSource1
            // 
            this.lotBindingSource1.DataSource = typeof(WereDesktop.Lot);
            // 
            // lotGridView
            // 
            this.lotGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity1,
            this.colExpirationDate,
            this.colLotNumber});
            this.lotGridView.GridControl = this.lotGridControl;
            this.lotGridView.Name = "lotGridView";
            this.lotGridView.OptionsBehavior.Editable = false;
            this.lotGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Количество";
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.MinWidth = 25;
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 0;
            this.colQuantity1.Width = 94;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Срок на годност";
            this.colExpirationDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colExpirationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.MinWidth = 25;
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 1;
            this.colExpirationDate.Width = 94;
            // 
            // colLotNumber
            // 
            this.colLotNumber.Caption = "Номер на партида";
            this.colLotNumber.FieldName = "LotNumber";
            this.colLotNumber.MinWidth = 25;
            this.colLotNumber.Name = "colLotNumber";
            this.colLotNumber.Visible = true;
            this.colLotNumber.VisibleIndex = 2;
            this.colLotNumber.Width = 94;
            // 
            // lotControlPanel
            // 
            this.lotControlPanel.Controls.Add(this.deleteLotButton);
            this.lotControlPanel.Controls.Add(this.editLotButton);
            this.lotControlPanel.Controls.Add(this.addLotButton);
            this.lotControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lotControlPanel.Location = new System.Drawing.Point(0, 0);
            this.lotControlPanel.Name = "lotControlPanel";
            this.lotControlPanel.Size = new System.Drawing.Size(951, 32);
            this.lotControlPanel.TabIndex = 4;
            // 
            // deleteLotButton
            // 
            this.deleteLotButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteLotButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteLotButton.ImageOptions.Image")));
            this.deleteLotButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteLotButton.Location = new System.Drawing.Point(52, 2);
            this.deleteLotButton.Name = "deleteLotButton";
            this.deleteLotButton.Size = new System.Drawing.Size(25, 28);
            this.deleteLotButton.TabIndex = 2;
            this.deleteLotButton.Text = "simpleButton1";
            this.deleteLotButton.Click += new System.EventHandler(this.deleteLotButton_Click);
            // 
            // editLotButton
            // 
            this.editLotButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editLotButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editLotButton.ImageOptions.Image")));
            this.editLotButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editLotButton.Location = new System.Drawing.Point(27, 2);
            this.editLotButton.Name = "editLotButton";
            this.editLotButton.Size = new System.Drawing.Size(25, 28);
            this.editLotButton.TabIndex = 1;
            this.editLotButton.Click += new System.EventHandler(this.editLotButton_Click);
            // 
            // addLotButton
            // 
            this.addLotButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addLotButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addLotButton.ImageOptions.Image")));
            this.addLotButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addLotButton.Location = new System.Drawing.Point(2, 2);
            this.addLotButton.Name = "addLotButton";
            this.addLotButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addLotButton.Size = new System.Drawing.Size(25, 28);
            this.addLotButton.TabIndex = 0;
            this.addLotButton.Click += new System.EventHandler(this.addLotButton_Click);
            // 
            // barcodeTabPage
            // 
            this.barcodeTabPage.Controls.Add(this.barcodeGridControl);
            this.barcodeTabPage.Controls.Add(this.panelControl1);
            this.barcodeTabPage.Name = "barcodeTabPage";
            this.barcodeTabPage.Size = new System.Drawing.Size(951, 233);
            this.barcodeTabPage.Text = "Баркод";
            // 
            // barcodeGridControl
            // 
            this.barcodeGridControl.DataSource = this.barcodeBindingSource;
            this.barcodeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeGridControl.Location = new System.Drawing.Point(0, 32);
            this.barcodeGridControl.MainView = this.barcodeGridView;
            this.barcodeGridControl.Name = "barcodeGridControl";
            this.barcodeGridControl.Size = new System.Drawing.Size(951, 201);
            this.barcodeGridControl.TabIndex = 5;
            this.barcodeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.barcodeGridView});
            this.barcodeGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeGridControl_KeyDown);
            this.barcodeGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.barcodeGridControl_MouseDoubleClick);
            // 
            // barcodeBindingSource
            // 
            this.barcodeBindingSource.DataSource = typeof(WereDesktop.Barcode);
            // 
            // barcodeGridView
            // 
            this.barcodeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarcodeNumber});
            this.barcodeGridView.GridControl = this.barcodeGridControl;
            this.barcodeGridView.Name = "barcodeGridView";
            this.barcodeGridView.OptionsBehavior.Editable = false;
            this.barcodeGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colBarcodeNumber
            // 
            this.colBarcodeNumber.Caption = "Баркод номер";
            this.colBarcodeNumber.FieldName = "BarcodeNumber";
            this.colBarcodeNumber.MinWidth = 25;
            this.colBarcodeNumber.Name = "colBarcodeNumber";
            this.colBarcodeNumber.Visible = true;
            this.colBarcodeNumber.VisibleIndex = 0;
            this.colBarcodeNumber.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deleteBarcodeButton);
            this.panelControl1.Controls.Add(this.editBarcodeButton);
            this.panelControl1.Controls.Add(this.addBarcodeButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(951, 32);
            this.panelControl1.TabIndex = 4;
            // 
            // deleteBarcodeButton
            // 
            this.deleteBarcodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBarcodeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBarcodeButton.ImageOptions.Image")));
            this.deleteBarcodeButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteBarcodeButton.Location = new System.Drawing.Point(52, 2);
            this.deleteBarcodeButton.Name = "deleteBarcodeButton";
            this.deleteBarcodeButton.Size = new System.Drawing.Size(25, 28);
            this.deleteBarcodeButton.TabIndex = 2;
            this.deleteBarcodeButton.Text = "simpleButton1";
            this.deleteBarcodeButton.Click += new System.EventHandler(this.deleteBarcodeButton_Click);
            // 
            // editBarcodeButton
            // 
            this.editBarcodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editBarcodeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editBarcodeButton.ImageOptions.Image")));
            this.editBarcodeButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editBarcodeButton.Location = new System.Drawing.Point(27, 2);
            this.editBarcodeButton.Name = "editBarcodeButton";
            this.editBarcodeButton.Size = new System.Drawing.Size(25, 28);
            this.editBarcodeButton.TabIndex = 1;
            this.editBarcodeButton.Click += new System.EventHandler(this.editBarcodeButton_Click);
            // 
            // addBarcodeButton
            // 
            this.addBarcodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBarcodeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBarcodeButton.ImageOptions.Image")));
            this.addBarcodeButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addBarcodeButton.Location = new System.Drawing.Point(2, 2);
            this.addBarcodeButton.Name = "addBarcodeButton";
            this.addBarcodeButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addBarcodeButton.Size = new System.Drawing.Size(25, 28);
            this.addBarcodeButton.TabIndex = 0;
            this.addBarcodeButton.Click += new System.EventHandler(this.addBarcodeButton_Click);
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(WereDesktop.Lot);
            // 
            // XtraUserControlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "XtraUserControlProducts";
            this.Size = new System.Drawing.Size(953, 628);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productControlPanel)).EndInit();
            this.productControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTabControl)).EndInit();
            this.productTabControl.ResumeLayout(false);
            this.lotTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotControlPanel)).EndInit();
            this.lotControlPanel.ResumeLayout(false);
            this.barcodeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl productControlPanel;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView productGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraEditors.SimpleButton deleteProductButton;
        private DevExpress.XtraEditors.SimpleButton editProductButton;
        private DevExpress.XtraEditors.SimpleButton addProductButton;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private System.Windows.Forms.BindingSource lotBindingSource1;
        private DevExpress.XtraTab.XtraTabControl productTabControl;
        private DevExpress.XtraTab.XtraTabPage barcodeTabPage;
        private DevExpress.XtraTab.XtraTabPage lotTabPage;
        private DevExpress.XtraGrid.GridControl lotGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView lotGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNumber;
        private DevExpress.XtraEditors.PanelControl lotControlPanel;
        private DevExpress.XtraEditors.SimpleButton deleteLotButton;
        private DevExpress.XtraEditors.SimpleButton editLotButton;
        private DevExpress.XtraEditors.SimpleButton addLotButton;
        private DevExpress.XtraGrid.GridControl barcodeGridControl;
        private System.Windows.Forms.BindingSource barcodeBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView barcodeGridView;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton deleteBarcodeButton;
        private DevExpress.XtraEditors.SimpleButton editBarcodeButton;
        private DevExpress.XtraEditors.SimpleButton addBarcodeButton;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeNumber;
    }
}
