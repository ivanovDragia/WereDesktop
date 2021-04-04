
namespace WereDesktop.Forms
{
    partial class EditLotForm
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
            this.lotQuantityET = new DevExpress.XtraEditors.TextEdit();
            this.lotDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lotNumberET = new DevExpress.XtraEditors.TextEdit();
            this.EditLotButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lotQuantityET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotNumberET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количесто:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Срок на годност:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер на партида:";
            // 
            // lotQuantityET
            // 
            this.lotQuantityET.Location = new System.Drawing.Point(149, 6);
            this.lotQuantityET.Name = "lotQuantityET";
            this.lotQuantityET.Size = new System.Drawing.Size(163, 22);
            this.lotQuantityET.TabIndex = 5;
            this.lotQuantityET.Validating += new System.ComponentModel.CancelEventHandler(this.lotQuantityET_Validating);
            // 
            // lotDateEdit
            // 
            this.lotDateEdit.EditValue = null;
            this.lotDateEdit.Location = new System.Drawing.Point(149, 32);
            this.lotDateEdit.Name = "lotDateEdit";
            this.lotDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lotDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.lotDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lotDateEdit.Properties.MaskSettings.Set("mask", "g");
            this.lotDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lotDateEdit.Properties.UseMaskAsDisplayFormat = true;
            this.lotDateEdit.Size = new System.Drawing.Size(163, 22);
            this.lotDateEdit.TabIndex = 6;
            this.lotDateEdit.Validating += new System.ComponentModel.CancelEventHandler(this.lotDateEdit_Validating);
            // 
            // lotNumberET
            // 
            this.lotNumberET.Location = new System.Drawing.Point(149, 59);
            this.lotNumberET.Name = "lotNumberET";
            this.lotNumberET.Size = new System.Drawing.Size(163, 22);
            this.lotNumberET.TabIndex = 7;
            this.lotNumberET.Validating += new System.ComponentModel.CancelEventHandler(this.lotNumberET_Validating);
            // 
            // EditLotButton
            // 
            this.EditLotButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditLotButton.Location = new System.Drawing.Point(0, 101);
            this.EditLotButton.Name = "EditLotButton";
            this.EditLotButton.Size = new System.Drawing.Size(324, 29);
            this.EditLotButton.TabIndex = 8;
            this.EditLotButton.Text = "Редактирай";
            this.EditLotButton.Click += new System.EventHandler(this.EditLotButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // EditLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 130);
            this.Controls.Add(this.EditLotButton);
            this.Controls.Add(this.lotNumberET);
            this.Controls.Add(this.lotDateEdit);
            this.Controls.Add(this.lotQuantityET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "EditLotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактиране на партида";
            this.Load += new System.EventHandler(this.EditLotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lotQuantityET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotNumberET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit lotQuantityET;
        private DevExpress.XtraEditors.DateEdit lotDateEdit;
        private DevExpress.XtraEditors.TextEdit lotNumberET;
        private DevExpress.XtraEditors.SimpleButton EditLotButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}