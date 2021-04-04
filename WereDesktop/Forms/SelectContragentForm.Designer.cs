
namespace WereDesktop.Forms
{
    partial class SelectContragentForm
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
            this.contragentTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.contragentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBulstat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVatNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCity = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAddress = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMrp = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPhoneNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.selectContragentButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contragentTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contragentTreeListLookUpEdit
            // 
            this.contragentTreeListLookUpEdit.Location = new System.Drawing.Point(12, 12);
            this.contragentTreeListLookUpEdit.Name = "contragentTreeListLookUpEdit";
            this.contragentTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contragentTreeListLookUpEdit.Properties.DataSource = this.contragentBindingSource;
            this.contragentTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.contragentTreeListLookUpEdit.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.contragentTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.contragentTreeListLookUpEdit.Size = new System.Drawing.Size(218, 22);
            this.contragentTreeListLookUpEdit.TabIndex = 0;
            this.contragentTreeListLookUpEdit.Validating += new System.ComponentModel.CancelEventHandler(this.contragentTreeListLookUpEdit_Validating);
            // 
            // contragentBindingSource
            // 
            this.contragentBindingSource.DataSource = typeof(WereDesktop.Contragent);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colBulstat,
            this.colVatNumber,
            this.colCity,
            this.colAddress,
            this.colMrp,
            this.colPhoneNumber});
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colBulstat
            // 
            this.colBulstat.FieldName = "Bulstat";
            this.colBulstat.Name = "colBulstat";
            this.colBulstat.Visible = true;
            this.colBulstat.VisibleIndex = 1;
            // 
            // colVatNumber
            // 
            this.colVatNumber.FieldName = "VatNumber";
            this.colVatNumber.Name = "colVatNumber";
            this.colVatNumber.Visible = true;
            this.colVatNumber.VisibleIndex = 2;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colMrp
            // 
            this.colMrp.FieldName = "Mrp";
            this.colMrp.Name = "colMrp";
            this.colMrp.Visible = true;
            this.colMrp.VisibleIndex = 5;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 6;
            // 
            // selectContragentButton
            // 
            this.selectContragentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectContragentButton.Location = new System.Drawing.Point(0, 52);
            this.selectContragentButton.Name = "selectContragentButton";
            this.selectContragentButton.Size = new System.Drawing.Size(242, 29);
            this.selectContragentButton.TabIndex = 1;
            this.selectContragentButton.Text = "Избери";
            this.selectContragentButton.Click += new System.EventHandler(this.selectContragentButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // SelectContragentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 81);
            this.Controls.Add(this.selectContragentButton);
            this.Controls.Add(this.contragentTreeListLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "SelectContragentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изберете контрагент";
            ((System.ComponentModel.ISupportInitialize)(this.contragentTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contragentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TreeListLookUpEdit contragentTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.SimpleButton selectContragentButton;
        private System.Windows.Forms.BindingSource contragentBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBulstat;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVatNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCity;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAddress;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMrp;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPhoneNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}