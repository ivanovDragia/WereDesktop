
namespace WereDesktop.Forms
{
    partial class EditDocumentForm
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
            this.editDocumentSourceLabel = new System.Windows.Forms.Label();
            this.editDocumentDestinationLabel = new System.Windows.Forms.Label();
            this.editDocumentNumberLabel = new System.Windows.Forms.Label();
            this.editDocumentDateLabel = new System.Windows.Forms.Label();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editDocumentSourceLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editDocumentDestinationLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.editDocumentNumberTE = new DevExpress.XtraEditors.TextEdit();
            this.editDocumentDateTE = new DevExpress.XtraEditors.TextEdit();
            this.editDocumentBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentSourceLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentDestinationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentNumberTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentDateTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // editDocumentSourceLabel
            // 
            this.editDocumentSourceLabel.AutoSize = true;
            this.editDocumentSourceLabel.Location = new System.Drawing.Point(13, 13);
            this.editDocumentSourceLabel.Name = "editDocumentSourceLabel";
            this.editDocumentSourceLabel.Size = new System.Drawing.Size(76, 17);
            this.editDocumentSourceLabel.TabIndex = 0;
            this.editDocumentSourceLabel.Text = "Destination";
            // 
            // editDocumentDestinationLabel
            // 
            this.editDocumentDestinationLabel.AutoSize = true;
            this.editDocumentDestinationLabel.Location = new System.Drawing.Point(12, 53);
            this.editDocumentDestinationLabel.Name = "editDocumentDestinationLabel";
            this.editDocumentDestinationLabel.Size = new System.Drawing.Size(51, 17);
            this.editDocumentDestinationLabel.TabIndex = 1;
            this.editDocumentDestinationLabel.Text = "Source";
            // 
            // editDocumentNumberLabel
            // 
            this.editDocumentNumberLabel.AutoSize = true;
            this.editDocumentNumberLabel.Location = new System.Drawing.Point(12, 85);
            this.editDocumentNumberLabel.Name = "editDocumentNumberLabel";
            this.editDocumentNumberLabel.Size = new System.Drawing.Size(57, 17);
            this.editDocumentNumberLabel.TabIndex = 2;
            this.editDocumentNumberLabel.Text = "Number";
            // 
            // editDocumentDateLabel
            // 
            this.editDocumentDateLabel.AutoSize = true;
            this.editDocumentDateLabel.Location = new System.Drawing.Point(12, 115);
            this.editDocumentDateLabel.Name = "editDocumentDateLabel";
            this.editDocumentDateLabel.Size = new System.Drawing.Size(37, 17);
            this.editDocumentDateLabel.TabIndex = 3;
            this.editDocumentDateLabel.Text = "Date";
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
            // editDocumentSourceLookUpEdit
            // 
            this.editDocumentSourceLookUpEdit.EditValue = "";
            this.editDocumentSourceLookUpEdit.Location = new System.Drawing.Point(95, 10);
            this.editDocumentSourceLookUpEdit.Name = "editDocumentSourceLookUpEdit";
            this.editDocumentSourceLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDocumentSourceLookUpEdit.Properties.DisplayMember = "Name";
            this.editDocumentSourceLookUpEdit.Properties.TreeList = this.treeList1;
            this.editDocumentSourceLookUpEdit.Properties.UseReadOnlyAppearance = false;
            this.editDocumentSourceLookUpEdit.Properties.ValueMember = "ID";
            this.editDocumentSourceLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.editDocumentSourceLookUpEdit.TabIndex = 14;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.Location = new System.Drawing.Point(301, 223);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
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
            this.treeListColumn2.VisibleIndex = 2;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.FieldName = "ProductNumber";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            // 
            // editDocumentDestinationLookUpEdit
            // 
            this.editDocumentDestinationLookUpEdit.EditValue = "";
            this.editDocumentDestinationLookUpEdit.Location = new System.Drawing.Point(95, 48);
            this.editDocumentDestinationLookUpEdit.Name = "editDocumentDestinationLookUpEdit";
            this.editDocumentDestinationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDocumentDestinationLookUpEdit.Properties.DisplayMember = "Name";
            this.editDocumentDestinationLookUpEdit.Properties.TreeList = this.treeList2;
            this.editDocumentDestinationLookUpEdit.Properties.UseReadOnlyAppearance = false;
            this.editDocumentDestinationLookUpEdit.Properties.ValueMember = "ID";
            this.editDocumentDestinationLookUpEdit.Size = new System.Drawing.Size(154, 22);
            this.editDocumentDestinationLookUpEdit.TabIndex = 15;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9});
            this.treeList2.Location = new System.Drawing.Point(320, 231);
            this.treeList2.Name = "treeList2";
            this.treeList2.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList2.Size = new System.Drawing.Size(400, 200);
            this.treeList2.TabIndex = 0;
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
            this.treeListColumn8.VisibleIndex = 2;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.FieldName = "ProductNumber";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Visible = true;
            this.treeListColumn9.VisibleIndex = 1;
            // 
            // editDocumentNumberTE
            // 
            this.editDocumentNumberTE.Location = new System.Drawing.Point(95, 82);
            this.editDocumentNumberTE.Name = "editDocumentNumberTE";
            this.editDocumentNumberTE.Properties.ReadOnly = true;
            this.editDocumentNumberTE.Size = new System.Drawing.Size(125, 22);
            this.editDocumentNumberTE.TabIndex = 16;
            // 
            // editDocumentDateTE
            // 
            this.editDocumentDateTE.Location = new System.Drawing.Point(95, 110);
            this.editDocumentDateTE.Name = "editDocumentDateTE";
            this.editDocumentDateTE.Properties.ReadOnly = true;
            this.editDocumentDateTE.Size = new System.Drawing.Size(125, 22);
            this.editDocumentDateTE.TabIndex = 17;
            // 
            // editDocumentBtn
            // 
            this.editDocumentBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editDocumentBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editDocumentBtn.Location = new System.Drawing.Point(0, 154);
            this.editDocumentBtn.Name = "editDocumentBtn";
            this.editDocumentBtn.Size = new System.Drawing.Size(264, 29);
            this.editDocumentBtn.TabIndex = 18;
            this.editDocumentBtn.Text = "Edit";
            this.editDocumentBtn.Click += new System.EventHandler(this.editDocumentBtn_Click);
            // 
            // EditDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 183);
            this.Controls.Add(this.editDocumentBtn);
            this.Controls.Add(this.editDocumentDateTE);
            this.Controls.Add(this.editDocumentNumberTE);
            this.Controls.Add(this.editDocumentDestinationLookUpEdit);
            this.Controls.Add(this.editDocumentSourceLookUpEdit);
            this.Controls.Add(this.editDocumentDateLabel);
            this.Controls.Add(this.editDocumentNumberLabel);
            this.Controls.Add(this.editDocumentDestinationLabel);
            this.Controls.Add(this.editDocumentSourceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "EditDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактиране на документ";
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentSourceLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentDestinationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentNumberTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDocumentDateTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editDocumentSourceLabel;
        private System.Windows.Forms.Label editDocumentDestinationLabel;
        private System.Windows.Forms.Label editDocumentNumberLabel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraEditors.TreeListLookUpEdit editDocumentSourceLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.TreeListLookUpEdit editDocumentDestinationLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraEditors.TextEdit editDocumentNumberTE;
        private DevExpress.XtraEditors.TextEdit editDocumentDateTE;
        private DevExpress.XtraEditors.SimpleButton editDocumentBtn;
        private System.Windows.Forms.Label editDocumentDateLabel;
    }
}