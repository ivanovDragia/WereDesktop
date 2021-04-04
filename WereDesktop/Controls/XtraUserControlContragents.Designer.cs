
namespace WereDesktop.Controls
{
    partial class XtraUserControlContragents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlContragents));
            this.contragentControlPanel = new DevExpress.XtraEditors.PanelControl();
            this.deleteContragentButton = new DevExpress.XtraEditors.SimpleButton();
            this.editContragentButton = new DevExpress.XtraEditors.SimpleButton();
            this.addContragentButton = new DevExpress.XtraEditors.SimpleButton();
            this.contragentsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contragentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBulstat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMrp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contragentControlPanel)).BeginInit();
            this.contragentControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contragentsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contragentControlPanel
            // 
            this.contragentControlPanel.Controls.Add(this.deleteContragentButton);
            this.contragentControlPanel.Controls.Add(this.editContragentButton);
            this.contragentControlPanel.Controls.Add(this.addContragentButton);
            this.contragentControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contragentControlPanel.Location = new System.Drawing.Point(0, 0);
            this.contragentControlPanel.Name = "contragentControlPanel";
            this.contragentControlPanel.Size = new System.Drawing.Size(1184, 32);
            this.contragentControlPanel.TabIndex = 1;
            // 
            // deleteContragentButton
            // 
            this.deleteContragentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteContragentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteContragentButton.ImageOptions.Image")));
            this.deleteContragentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteContragentButton.Location = new System.Drawing.Point(52, 2);
            this.deleteContragentButton.Name = "deleteContragentButton";
            this.deleteContragentButton.Size = new System.Drawing.Size(25, 28);
            this.deleteContragentButton.TabIndex = 2;
            this.deleteContragentButton.Text = "simpleButton1";
            this.deleteContragentButton.Click += new System.EventHandler(this.deleteContragentButton_Click);
            // 
            // editContragentButton
            // 
            this.editContragentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editContragentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editContragentButton.ImageOptions.Image")));
            this.editContragentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editContragentButton.Location = new System.Drawing.Point(27, 2);
            this.editContragentButton.Name = "editContragentButton";
            this.editContragentButton.Size = new System.Drawing.Size(25, 28);
            this.editContragentButton.TabIndex = 1;
            this.editContragentButton.Click += new System.EventHandler(this.editContragentButton_Click);
            // 
            // addContragentButton
            // 
            this.addContragentButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addContragentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addContragentButton.ImageOptions.Image")));
            this.addContragentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addContragentButton.Location = new System.Drawing.Point(2, 2);
            this.addContragentButton.Name = "addContragentButton";
            this.addContragentButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.addContragentButton.Size = new System.Drawing.Size(25, 28);
            this.addContragentButton.TabIndex = 0;
            this.addContragentButton.Click += new System.EventHandler(this.addContragentButton_Click);
            // 
            // contragentsGridControl
            // 
            this.contragentsGridControl.DataSource = this.contragentBindingSource;
            this.contragentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contragentsGridControl.Location = new System.Drawing.Point(0, 32);
            this.contragentsGridControl.MainView = this.contragentsGridView;
            this.contragentsGridControl.Name = "contragentsGridControl";
            this.contragentsGridControl.Size = new System.Drawing.Size(1184, 431);
            this.contragentsGridControl.TabIndex = 2;
            this.contragentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.contragentsGridView});
            this.contragentsGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contragentsGridControl_KeyDown);
            this.contragentsGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.contragentsGridControl_MouseDoubleClick);
            // 
            // contragentBindingSource
            // 
            this.contragentBindingSource.DataSource = typeof(WereDesktop.Contragent);
            // 
            // contragentsGridView
            // 
            this.contragentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colBulstat,
            this.colVatNumber,
            this.colCity,
            this.colAddress,
            this.colMrp,
            this.colPhoneNumber});
            this.contragentsGridView.GridControl = this.contragentsGridControl;
            this.contragentsGridView.Name = "contragentsGridView";
            this.contragentsGridView.OptionsBehavior.Editable = false;
            this.contragentsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colName
            // 
            this.colName.Caption = "Име";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colBulstat
            // 
            this.colBulstat.Caption = "Булстат";
            this.colBulstat.FieldName = "Bulstat";
            this.colBulstat.MinWidth = 25;
            this.colBulstat.Name = "colBulstat";
            this.colBulstat.Visible = true;
            this.colBulstat.VisibleIndex = 1;
            this.colBulstat.Width = 94;
            // 
            // colVatNumber
            // 
            this.colVatNumber.Caption = "ВАТ номер";
            this.colVatNumber.FieldName = "VatNumber";
            this.colVatNumber.MinWidth = 25;
            this.colVatNumber.Name = "colVatNumber";
            this.colVatNumber.Visible = true;
            this.colVatNumber.VisibleIndex = 2;
            this.colVatNumber.Width = 94;
            // 
            // colCity
            // 
            this.colCity.Caption = "Град";
            this.colCity.FieldName = "City";
            this.colCity.MinWidth = 25;
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            this.colCity.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Адрес";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 94;
            // 
            // colMrp
            // 
            this.colMrp.Caption = "МОЛ";
            this.colMrp.FieldName = "Mrp";
            this.colMrp.MinWidth = 25;
            this.colMrp.Name = "colMrp";
            this.colMrp.Visible = true;
            this.colMrp.VisibleIndex = 5;
            this.colMrp.Width = 94;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Телефонен номер";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 25;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 6;
            this.colPhoneNumber.Width = 94;
            // 
            // XtraUserControlContragents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contragentsGridControl);
            this.Controls.Add(this.contragentControlPanel);
            this.Name = "XtraUserControlContragents";
            this.Size = new System.Drawing.Size(1184, 463);
            ((System.ComponentModel.ISupportInitialize)(this.contragentControlPanel)).EndInit();
            this.contragentControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contragentsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl contragentControlPanel;
        private DevExpress.XtraEditors.SimpleButton deleteContragentButton;
        private DevExpress.XtraEditors.SimpleButton editContragentButton;
        private DevExpress.XtraEditors.SimpleButton addContragentButton;
        private DevExpress.XtraGrid.GridControl contragentsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView contragentsGridView;
        private System.Windows.Forms.BindingSource contragentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBulstat;
        private DevExpress.XtraGrid.Columns.GridColumn colVatNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMrp;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
    }
}
