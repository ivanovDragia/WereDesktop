
namespace WereDesktop.Forms
{
    partial class AddDocumentRowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityET = new DevExpress.XtraEditors.TextEdit();
            this.AddDocumentRowButton = new DevExpress.XtraEditors.SimpleButton();
            this.productTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPrice = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colProductNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lotTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colLotNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQuantity1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colExpirationDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantityET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продукт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Партида:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество:";
            // 
            // quantityET
            // 
            this.quantityET.Location = new System.Drawing.Point(104, 69);
            this.quantityET.Name = "quantityET";
            this.quantityET.Properties.BeepOnError = false;
            this.quantityET.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.quantityET.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.quantityET.Properties.MaskSettings.Set("mask", "f");
            this.quantityET.Properties.UseMaskAsDisplayFormat = true;
            this.quantityET.Size = new System.Drawing.Size(154, 22);
            this.quantityET.TabIndex = 5;
            this.quantityET.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // AddDocumentRowButton
            // 
            this.AddDocumentRowButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddDocumentRowButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddDocumentRowButton.Location = new System.Drawing.Point(0, 132);
            this.AddDocumentRowButton.Name = "AddDocumentRowButton";
            this.AddDocumentRowButton.Size = new System.Drawing.Size(271, 29);
            this.AddDocumentRowButton.TabIndex = 6;
            this.AddDocumentRowButton.Text = "Добави";
            this.AddDocumentRowButton.Click += new System.EventHandler(this.AddDocumentRowButton_Click);
            // 
            // productTreeListLookUpEdit
            // 
            this.productTreeListLookUpEdit.Location = new System.Drawing.Point(104, 6);
            this.productTreeListLookUpEdit.Name = "productTreeListLookUpEdit";
            this.productTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productTreeListLookUpEdit.Properties.DataSource = this.productBindingSource;
            this.productTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.productTreeListLookUpEdit.Properties.NullText = "";
            this.productTreeListLookUpEdit.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.productTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.productTreeListLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.productTreeListLookUpEdit.TabIndex = 7;
            this.productTreeListLookUpEdit.EditValueChanged += new System.EventHandler(this.productTreeListLookUpEdit_EditValueChanged);
            this.productTreeListLookUpEdit.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WereDesktop.Product);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colPrice,
            this.colProductNumber});
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
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // colProductNumber
            // 
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.Visible = true;
            this.colProductNumber.VisibleIndex = 2;
            // 
            // lotTreeListLookUpEdit
            // 
            this.lotTreeListLookUpEdit.Location = new System.Drawing.Point(104, 37);
            this.lotTreeListLookUpEdit.Name = "lotTreeListLookUpEdit";
            this.lotTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lotTreeListLookUpEdit.Properties.DataSource = this.lotBindingSource;
            this.lotTreeListLookUpEdit.Properties.DisplayMember = "LotNumber";
            this.lotTreeListLookUpEdit.Properties.NullText = "";
            this.lotTreeListLookUpEdit.Properties.TreeList = this.treeList1;
            this.lotTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.lotTreeListLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.lotTreeListLookUpEdit.TabIndex = 8;
            this.lotTreeListLookUpEdit.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(WereDesktop.Lot);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLotNumber,
            this.colQuantity1,
            this.colExpirationDate});
            this.treeList1.Location = new System.Drawing.Point(-65, -20);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
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
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // AddDocumentRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 161);
            this.Controls.Add(this.lotTreeListLookUpEdit);
            this.Controls.Add(this.productTreeListLookUpEdit);
            this.Controls.Add(this.AddDocumentRowButton);
            this.Controls.Add(this.quantityET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDocumentRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на ред в документ";
            ((System.ComponentModel.ISupportInitialize)(this.quantityET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit quantityET;
        private DevExpress.XtraEditors.SimpleButton AddDocumentRowButton;
        private DevExpress.XtraEditors.TreeListLookUpEdit productTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TreeListLookUpEdit lotTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrice;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLotNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQuantity1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExpirationDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colProductNumber;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}