
namespace WereDesktop.Forms
{
    partial class EditDocumentRowForm
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
            this.EditDocumentRowProductLabel = new System.Windows.Forms.Label();
            this.EditDocumentRowLotLabel = new System.Windows.Forms.Label();
            this.EditDocumentRowQuantityLabel = new System.Windows.Forms.Label();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colProductNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editDocumentRowQuantityTE = new DevExpress.XtraEditors.TextEdit();
            this.editDocumentRowBtn = new DevExpress.XtraEditors.SimpleButton();
            this.editDocumentRowProductTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLotNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQuantity1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colExpirationDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn12 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editDocumentRowLotTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn13 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn14 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn15 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowQuantityTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowProductTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowLotTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EditDocumentRowProductLabel
            // 
            this.EditDocumentRowProductLabel.AutoSize = true;
            this.EditDocumentRowProductLabel.Location = new System.Drawing.Point(13, 13);
            this.EditDocumentRowProductLabel.Name = "EditDocumentRowProductLabel";
            this.EditDocumentRowProductLabel.Size = new System.Drawing.Size(69, 17);
            this.EditDocumentRowProductLabel.TabIndex = 0;
            this.EditDocumentRowProductLabel.Text = "Продукт:";
            // 
            // EditDocumentRowLotLabel
            // 
            this.EditDocumentRowLotLabel.AutoSize = true;
            this.EditDocumentRowLotLabel.Location = new System.Drawing.Point(13, 49);
            this.EditDocumentRowLotLabel.Name = "EditDocumentRowLotLabel";
            this.EditDocumentRowLotLabel.Size = new System.Drawing.Size(68, 17);
            this.EditDocumentRowLotLabel.TabIndex = 1;
            this.EditDocumentRowLotLabel.Text = "Партида:";
            // 
            // EditDocumentRowQuantityLabel
            // 
            this.EditDocumentRowQuantityLabel.AutoSize = true;
            this.EditDocumentRowQuantityLabel.Location = new System.Drawing.Point(13, 83);
            this.EditDocumentRowQuantityLabel.Name = "EditDocumentRowQuantityLabel";
            this.EditDocumentRowQuantityLabel.Size = new System.Drawing.Size(90, 17);
            this.EditDocumentRowQuantityLabel.TabIndex = 2;
            this.EditDocumentRowQuantityLabel.Text = "Количество:";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colProductNumber
            // 
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.Visible = true;
            this.colProductNumber.VisibleIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.FieldName = "Price";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.FieldName = "ProductNumber";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // editDocumentRowQuantityTE
            // 
            this.editDocumentRowQuantityTE.Location = new System.Drawing.Point(80, 78);
            this.editDocumentRowQuantityTE.Name = "editDocumentRowQuantityTE";
            this.editDocumentRowQuantityTE.Properties.BeepOnError = false;
            this.editDocumentRowQuantityTE.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.editDocumentRowQuantityTE.Properties.MaskSettings.Set("mask", "f");
            this.editDocumentRowQuantityTE.Size = new System.Drawing.Size(125, 22);
            this.editDocumentRowQuantityTE.TabIndex = 10;
            this.editDocumentRowQuantityTE.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // editDocumentRowBtn
            // 
            this.editDocumentRowBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editDocumentRowBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editDocumentRowBtn.Location = new System.Drawing.Point(0, 119);
            this.editDocumentRowBtn.Name = "editDocumentRowBtn";
            this.editDocumentRowBtn.Size = new System.Drawing.Size(255, 29);
            this.editDocumentRowBtn.TabIndex = 11;
            this.editDocumentRowBtn.Text = "Редактирай";
            this.editDocumentRowBtn.Click += new System.EventHandler(this.editDocumentRowBtn_Click);
            // 
            // editDocumentRowProductTreeListLookUpEdit
            // 
            this.editDocumentRowProductTreeListLookUpEdit.EditValue = "";
            this.editDocumentRowProductTreeListLookUpEdit.Location = new System.Drawing.Point(80, 8);
            this.editDocumentRowProductTreeListLookUpEdit.Name = "editDocumentRowProductTreeListLookUpEdit";
            this.editDocumentRowProductTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDocumentRowProductTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.editDocumentRowProductTreeListLookUpEdit.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.editDocumentRowProductTreeListLookUpEdit.Properties.UseReadOnlyAppearance = false;
            this.editDocumentRowProductTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.editDocumentRowProductTreeListLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.editDocumentRowProductTreeListLookUpEdit.TabIndex = 12;
            this.editDocumentRowProductTreeListLookUpEdit.EditValueChanged += new System.EventHandler(this.editDocumentRowProductTreeListLookUpEdit_EditValueChanged);
            this.editDocumentRowProductTreeListLookUpEdit.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6});
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(263, 173);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.FieldName = "Name";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.FieldName = "Price";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 2;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.FieldName = "ProductNumber";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 1;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.FieldName = "Name";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 0;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.FieldName = "Price";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 1;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.FieldName = "ProductNumber";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 2;
            // 
            // colLotNumber
            // 
            this.colLotNumber.FieldName = "LotNumber";
            this.colLotNumber.Name = "colLotNumber";
            this.colLotNumber.Visible = true;
            this.colLotNumber.VisibleIndex = 0;
            // 
            // colQuantity1
            // 
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 1;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 2;
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.FieldName = "LotNumber";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 0;
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.FieldName = "Quantity";
            this.treeListColumn11.Name = "treeListColumn11";
            this.treeListColumn11.Visible = true;
            this.treeListColumn11.VisibleIndex = 1;
            // 
            // treeListColumn12
            // 
            this.treeListColumn12.FieldName = "ExpirationDate";
            this.treeListColumn12.Name = "treeListColumn12";
            this.treeListColumn12.Visible = true;
            this.treeListColumn12.VisibleIndex = 2;
            // 
            // editDocumentRowLotTreeListLookUpEdit
            // 
            this.editDocumentRowLotTreeListLookUpEdit.EditValue = "";
            this.editDocumentRowLotTreeListLookUpEdit.Location = new System.Drawing.Point(80, 44);
            this.editDocumentRowLotTreeListLookUpEdit.Name = "editDocumentRowLotTreeListLookUpEdit";
            this.editDocumentRowLotTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDocumentRowLotTreeListLookUpEdit.Properties.DisplayMember = "LotNumber";
            this.editDocumentRowLotTreeListLookUpEdit.Properties.TreeList = this.treeList1;
            this.editDocumentRowLotTreeListLookUpEdit.Properties.UseReadOnlyAppearance = false;
            this.editDocumentRowLotTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.editDocumentRowLotTreeListLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.editDocumentRowLotTreeListLookUpEdit.TabIndex = 15;
            this.editDocumentRowLotTreeListLookUpEdit.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn13,
            this.treeListColumn14,
            this.treeListColumn15});
            this.treeList1.Location = new System.Drawing.Point(296, 167);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn13
            // 
            this.treeListColumn13.FieldName = "LotNumber";
            this.treeListColumn13.Name = "treeListColumn13";
            this.treeListColumn13.Visible = true;
            this.treeListColumn13.VisibleIndex = 0;
            // 
            // treeListColumn14
            // 
            this.treeListColumn14.FieldName = "Quantity";
            this.treeListColumn14.Name = "treeListColumn14";
            this.treeListColumn14.Visible = true;
            this.treeListColumn14.VisibleIndex = 1;
            // 
            // treeListColumn15
            // 
            this.treeListColumn15.FieldName = "ExpirationDate";
            this.treeListColumn15.Name = "treeListColumn15";
            this.treeListColumn15.Visible = true;
            this.treeListColumn15.VisibleIndex = 2;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // EditDocumentRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 148);
            this.Controls.Add(this.editDocumentRowLotTreeListLookUpEdit);
            this.Controls.Add(this.editDocumentRowProductTreeListLookUpEdit);
            this.Controls.Add(this.editDocumentRowBtn);
            this.Controls.Add(this.editDocumentRowQuantityTE);
            this.Controls.Add(this.EditDocumentRowQuantityLabel);
            this.Controls.Add(this.EditDocumentRowLotLabel);
            this.Controls.Add(this.EditDocumentRowProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "EditDocumentRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактиране на ред от документ";
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowQuantityTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowProductTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentRowLotTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditDocumentRowProductLabel;
        private System.Windows.Forms.Label EditDocumentRowLotLabel;
        private System.Windows.Forms.Label EditDocumentRowQuantityLabel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrice;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colProductNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.TextEdit editDocumentRowQuantityTE;
        private DevExpress.XtraEditors.SimpleButton editDocumentRowBtn;
        private DevExpress.XtraEditors.TreeListLookUpEdit editDocumentRowProductTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLotNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQuantity1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExpirationDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn12;
        private DevExpress.XtraEditors.TreeListLookUpEdit editDocumentRowLotTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn13;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn14;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn15;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}