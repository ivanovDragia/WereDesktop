
namespace WereDesktop.Controls
{
    partial class XtraUserControlDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlDocuments));
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.documentsGridControl = new DevExpress.XtraGrid.GridControl();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSourceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestinationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentControlPanel = new DevExpress.XtraEditors.PanelControl();
            this.reportButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            this.editDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            this.addDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            this.timeEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.documentsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.documentRowsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.documentRowsGridControl = new DevExpress.XtraGrid.GridControl();
            this.documentRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentRowsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentRowPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.deleteDocumentRowButton = new DevExpress.XtraEditors.SimpleButton();
            this.editDocumentRowButton = new DevExpress.XtraEditors.SimpleButton();
            this.addDocumentRowButton = new DevExpress.XtraEditors.SimpleButton();
            this.documentPaymentXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.barcodesGridControl = new DevExpress.XtraGrid.GridControl();
            this.documentPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMethodOfPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).BeginInit();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentControlPanel)).BeginInit();
            this.documentControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsXtraTabControl)).BeginInit();
            this.documentsXtraTabControl.SuspendLayout();
            this.documentRowsXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowPanelControl)).BeginInit();
            this.documentRowPanelControl.SuspendLayout();
            this.documentPaymentXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Horizontal = false;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.documentsGridControl);
            this.splitContainerControl.Panel1.Controls.Add(this.documentControlPanel);
            this.splitContainerControl.Panel1.Controls.Add(this.timeEdit1);
            this.splitContainerControl.Panel1.Text = "Panel1";
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.documentsXtraTabControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1050, 618);
            this.splitContainerControl.SplitterPosition = 350;
            this.splitContainerControl.TabIndex = 0;
            // 
            // documentsGridControl
            // 
            this.documentsGridControl.DataSource = this.documentBindingSource;
            this.documentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsGridControl.Location = new System.Drawing.Point(0, 32);
            this.documentsGridControl.MainView = this.documentGridView;
            this.documentsGridControl.Name = "documentsGridControl";
            this.documentsGridControl.Size = new System.Drawing.Size(1050, 318);
            this.documentsGridControl.TabIndex = 2;
            this.documentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.documentGridView});
            this.documentsGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.documentsGridControl_KeyDown);
            this.documentsGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.documentsGridControl_MouseDoubleClick);
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(WereDesktop.Document);
            // 
            // documentGridView
            // 
            this.documentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSourceID,
            this.colDestinationID,
            this.colDocumentNumber,
            this.colDate});
            this.documentGridView.GridControl = this.documentsGridControl;
            this.documentGridView.Name = "documentGridView";
            this.documentGridView.OptionsBehavior.Editable = false;
            this.documentGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.documentGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.documentGridView_FocusedRowChanged);
            // 
            // colSourceID
            // 
            this.colSourceID.Caption = "Име на изпращач";
            this.colSourceID.FieldName = "Contragent.Name";
            this.colSourceID.MinWidth = 25;
            this.colSourceID.Name = "colSourceID";
            this.colSourceID.Visible = true;
            this.colSourceID.VisibleIndex = 0;
            this.colSourceID.Width = 94;
            // 
            // colDestinationID
            // 
            this.colDestinationID.Caption = "Име на получател";
            this.colDestinationID.FieldName = "Contragent1.Name";
            this.colDestinationID.MinWidth = 25;
            this.colDestinationID.Name = "colDestinationID";
            this.colDestinationID.Visible = true;
            this.colDestinationID.VisibleIndex = 1;
            this.colDestinationID.Width = 94;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Номер на документа";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.MinWidth = 25;
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 2;
            this.colDocumentNumber.Width = 94;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата на създаване на документа";
            this.colDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 94;
            // 
            // documentControlPanel
            // 
            this.documentControlPanel.Controls.Add(this.reportButton);
            this.documentControlPanel.Controls.Add(this.deleteDocumentButton);
            this.documentControlPanel.Controls.Add(this.editDocumentButton);
            this.documentControlPanel.Controls.Add(this.addDocumentButton);
            this.documentControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentControlPanel.Location = new System.Drawing.Point(0, 0);
            this.documentControlPanel.Name = "documentControlPanel";
            this.documentControlPanel.Size = new System.Drawing.Size(1050, 32);
            this.documentControlPanel.TabIndex = 1;
            // 
            // reportButton
            // 
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.ImageOptions.Image")));
            this.reportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.reportButton.Location = new System.Drawing.Point(77, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(25, 28);
            this.reportButton.TabIndex = 3;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            this.reportButton.MouseHover += new System.EventHandler(this.reportButton_MouseHover);
            // 
            // deleteDocumentButton
            // 
            this.deleteDocumentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteDocumentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocumentButton.ImageOptions.Image")));
            this.deleteDocumentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteDocumentButton.Location = new System.Drawing.Point(52, 2);
            this.deleteDocumentButton.Name = "deleteDocumentButton";
            this.deleteDocumentButton.Size = new System.Drawing.Size(25, 28);
            this.deleteDocumentButton.TabIndex = 2;
            this.deleteDocumentButton.Text = "simpleButton1";
            this.deleteDocumentButton.Click += new System.EventHandler(this.deleteDocumentButton_Click);
            // 
            // editDocumentButton
            // 
            this.editDocumentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editDocumentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editDocumentButton.ImageOptions.Image")));
            this.editDocumentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editDocumentButton.Location = new System.Drawing.Point(27, 2);
            this.editDocumentButton.Name = "editDocumentButton";
            this.editDocumentButton.Size = new System.Drawing.Size(25, 28);
            this.editDocumentButton.TabIndex = 1;
            this.editDocumentButton.Click += new System.EventHandler(this.editDocumentButton_Click);
            // 
            // addDocumentButton
            // 
            this.addDocumentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addDocumentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addDocumentButton.ImageOptions.Image")));
            this.addDocumentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addDocumentButton.Location = new System.Drawing.Point(2, 2);
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addDocumentButton.Size = new System.Drawing.Size(25, 28);
            this.addDocumentButton.TabIndex = 0;
            this.addDocumentButton.Visible = false;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(311, 231);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "T";
            this.timeEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.timeEdit1.Size = new System.Drawing.Size(125, 22);
            this.timeEdit1.TabIndex = 4;
            // 
            // documentsXtraTabControl
            // 
            this.documentsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.documentsXtraTabControl.Name = "documentsXtraTabControl";
            this.documentsXtraTabControl.SelectedTabPage = this.documentRowsXtraTabPage;
            this.documentsXtraTabControl.Size = new System.Drawing.Size(1050, 253);
            this.documentsXtraTabControl.TabIndex = 0;
            this.documentsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.documentRowsXtraTabPage,
            this.documentPaymentXtraTabPage});
            // 
            // documentRowsXtraTabPage
            // 
            this.documentRowsXtraTabPage.Controls.Add(this.documentRowsGridControl);
            this.documentRowsXtraTabPage.Controls.Add(this.documentRowPanelControl);
            this.documentRowsXtraTabPage.Name = "documentRowsXtraTabPage";
            this.documentRowsXtraTabPage.Size = new System.Drawing.Size(1048, 223);
            this.documentRowsXtraTabPage.Text = "Редове на документ";
            // 
            // documentRowsGridControl
            // 
            this.documentRowsGridControl.DataSource = this.documentRowBindingSource;
            this.documentRowsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentRowsGridControl.Location = new System.Drawing.Point(0, 32);
            this.documentRowsGridControl.MainView = this.documentRowsGridView;
            this.documentRowsGridControl.Name = "documentRowsGridControl";
            this.documentRowsGridControl.Size = new System.Drawing.Size(1048, 191);
            this.documentRowsGridControl.TabIndex = 4;
            this.documentRowsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.documentRowsGridView});
            this.documentRowsGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.documentRowsGridControl_KeyDown);
            this.documentRowsGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.documentRowsGridControl_MouseDoubleClick);
            // 
            // documentRowBindingSource
            // 
            this.documentRowBindingSource.DataSource = typeof(WereDesktop.DocumentRow);
            // 
            // documentRowsGridView
            // 
            this.documentRowsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colLotID,
            this.colQuantity,
            this.colSum});
            this.documentRowsGridView.GridControl = this.documentRowsGridControl;
            this.documentRowsGridView.Name = "documentRowsGridView";
            this.documentRowsGridView.OptionsBehavior.Editable = false;
            this.documentRowsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Име на продукт";
            this.colProductID.FieldName = "Product.Name";
            this.colProductID.MinWidth = 25;
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            this.colProductID.Width = 94;
            // 
            // colLotID
            // 
            this.colLotID.Caption = "Номер на партида";
            this.colLotID.FieldName = "Lot.LotNumber";
            this.colLotID.MinWidth = 25;
            this.colLotID.Name = "colLotID";
            this.colLotID.Visible = true;
            this.colLotID.VisibleIndex = 1;
            this.colLotID.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Количество";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 94;
            // 
            // colSum
            // 
            this.colSum.Caption = "Сума";
            this.colSum.FieldName = "Sum";
            this.colSum.MinWidth = 25;
            this.colSum.Name = "colSum";
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 3;
            this.colSum.Width = 94;
            // 
            // documentRowPanelControl
            // 
            this.documentRowPanelControl.Controls.Add(this.deleteDocumentRowButton);
            this.documentRowPanelControl.Controls.Add(this.editDocumentRowButton);
            this.documentRowPanelControl.Controls.Add(this.addDocumentRowButton);
            this.documentRowPanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentRowPanelControl.Location = new System.Drawing.Point(0, 0);
            this.documentRowPanelControl.Name = "documentRowPanelControl";
            this.documentRowPanelControl.Size = new System.Drawing.Size(1048, 32);
            this.documentRowPanelControl.TabIndex = 3;
            // 
            // deleteDocumentRowButton
            // 
            this.deleteDocumentRowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteDocumentRowButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocumentRowButton.ImageOptions.Image")));
            this.deleteDocumentRowButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteDocumentRowButton.Location = new System.Drawing.Point(52, 2);
            this.deleteDocumentRowButton.Name = "deleteDocumentRowButton";
            this.deleteDocumentRowButton.Size = new System.Drawing.Size(25, 28);
            this.deleteDocumentRowButton.TabIndex = 2;
            this.deleteDocumentRowButton.Text = "simpleButton1";
            this.deleteDocumentRowButton.Click += new System.EventHandler(this.deleteDocumentRowButton_Click);
            // 
            // editDocumentRowButton
            // 
            this.editDocumentRowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editDocumentRowButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editDocumentRowButton.ImageOptions.Image")));
            this.editDocumentRowButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editDocumentRowButton.Location = new System.Drawing.Point(27, 2);
            this.editDocumentRowButton.Name = "editDocumentRowButton";
            this.editDocumentRowButton.Size = new System.Drawing.Size(25, 28);
            this.editDocumentRowButton.TabIndex = 1;
            this.editDocumentRowButton.Click += new System.EventHandler(this.editDocumentRowButton_Click);
            // 
            // addDocumentRowButton
            // 
            this.addDocumentRowButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addDocumentRowButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addDocumentRowButton.ImageOptions.Image")));
            this.addDocumentRowButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addDocumentRowButton.Location = new System.Drawing.Point(2, 2);
            this.addDocumentRowButton.Name = "addDocumentRowButton";
            this.addDocumentRowButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addDocumentRowButton.Size = new System.Drawing.Size(25, 28);
            this.addDocumentRowButton.TabIndex = 0;
            this.addDocumentRowButton.Click += new System.EventHandler(this.addDocumentRowButton_Click);
            // 
            // documentPaymentXtraTabPage
            // 
            this.documentPaymentXtraTabPage.Controls.Add(this.barcodesGridControl);
            this.documentPaymentXtraTabPage.Name = "documentPaymentXtraTabPage";
            this.documentPaymentXtraTabPage.Size = new System.Drawing.Size(1048, 223);
            this.documentPaymentXtraTabPage.Text = "Плащане по документ";
            // 
            // barcodesGridControl
            // 
            this.barcodesGridControl.DataSource = this.documentPaymentBindingSource;
            this.barcodesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodesGridControl.Location = new System.Drawing.Point(0, 0);
            this.barcodesGridControl.MainView = this.barcodesGridView;
            this.barcodesGridControl.Name = "barcodesGridControl";
            this.barcodesGridControl.Size = new System.Drawing.Size(1048, 223);
            this.barcodesGridControl.TabIndex = 0;
            this.barcodesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.barcodesGridView});
            // 
            // documentPaymentBindingSource
            // 
            this.documentPaymentBindingSource.DataSource = typeof(WereDesktop.DocumentPayment);
            // 
            // barcodesGridView
            // 
            this.barcodesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMethodOfPayment,
            this.colPrice});
            this.barcodesGridView.GridControl = this.barcodesGridControl;
            this.barcodesGridView.Name = "barcodesGridView";
            this.barcodesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colMethodOfPayment
            // 
            this.colMethodOfPayment.Caption = "Начин на плащане";
            this.colMethodOfPayment.FieldName = "MethodOfPayment";
            this.colMethodOfPayment.MinWidth = 25;
            this.colMethodOfPayment.Name = "colMethodOfPayment";
            this.colMethodOfPayment.Visible = true;
            this.colMethodOfPayment.VisibleIndex = 0;
            this.colMethodOfPayment.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Сума";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 94;
            // 
            // documentBindingSource1
            // 
            this.documentBindingSource1.DataSource = typeof(WereDesktop.Document);
            // 
            // XtraUserControlDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "XtraUserControlDocuments";
            this.Size = new System.Drawing.Size(1050, 618);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).EndInit();
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentControlPanel)).EndInit();
            this.documentControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsXtraTabControl)).EndInit();
            this.documentsXtraTabControl.ResumeLayout(false);
            this.documentRowsXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentRowsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentRowPanelControl)).EndInit();
            this.documentRowPanelControl.ResumeLayout(false);
            this.documentPaymentXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.PanelControl documentControlPanel;
        private DevExpress.XtraEditors.SimpleButton deleteDocumentButton;
        private DevExpress.XtraEditors.SimpleButton editDocumentButton;
        private DevExpress.XtraEditors.SimpleButton addDocumentButton;
        private DevExpress.XtraGrid.GridControl documentsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView documentGridView;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceID;
        private DevExpress.XtraGrid.Columns.GridColumn colDestinationID;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private System.Windows.Forms.BindingSource documentBindingSource1;
        private System.Windows.Forms.BindingSource documentRowBindingSource;
        private DevExpress.XtraTab.XtraTabControl documentsXtraTabControl;
        private DevExpress.XtraTab.XtraTabPage documentRowsXtraTabPage;
        private DevExpress.XtraGrid.GridControl documentRowsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView documentRowsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colLotID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraEditors.PanelControl documentRowPanelControl;
        private DevExpress.XtraEditors.SimpleButton deleteDocumentRowButton;
        private DevExpress.XtraEditors.SimpleButton editDocumentRowButton;
        private DevExpress.XtraEditors.SimpleButton addDocumentRowButton;
        private DevExpress.XtraTab.XtraTabPage documentPaymentXtraTabPage;
        private DevExpress.XtraGrid.GridControl barcodesGridControl;
        private System.Windows.Forms.BindingSource documentPaymentBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView barcodesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMethodOfPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.DateTimeOffsetEdit timeEdit1;
        private DevExpress.XtraEditors.SimpleButton reportButton;
    }
}
