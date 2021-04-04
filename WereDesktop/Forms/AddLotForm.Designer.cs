
namespace WereDesktop.Forms
{
    partial class AddLotForm
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
            this.AddLotButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lotNumberET = new DevExpress.XtraEditors.TextEdit();
            this.lotQuantityET = new DevExpress.XtraEditors.TextEdit();
            this.lotDateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotNumberET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotQuantityET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок на годност";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер на партида";
            // 
            // AddLotButton
            // 
            this.AddLotButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddLotButton.Location = new System.Drawing.Point(0, 98);
            this.AddLotButton.Name = "AddLotButton";
            this.AddLotButton.Size = new System.Drawing.Size(334, 29);
            this.AddLotButton.TabIndex = 6;
            this.AddLotButton.Text = "Добави";
            this.AddLotButton.Click += new System.EventHandler(this.AddLotButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // lotNumberET
            // 
            this.lotNumberET.Location = new System.Drawing.Point(142, 62);
            this.lotNumberET.Name = "lotNumberET";
            this.lotNumberET.Size = new System.Drawing.Size(180, 22);
            this.lotNumberET.TabIndex = 5;
            this.lotNumberET.Validating += new System.ComponentModel.CancelEventHandler(this.lotNumberET_Validating);
            // 
            // lotQuantityET
            // 
            this.lotQuantityET.Location = new System.Drawing.Point(142, 10);
            this.lotQuantityET.Name = "lotQuantityET";
            this.lotQuantityET.Size = new System.Drawing.Size(180, 22);
            this.lotQuantityET.TabIndex = 4;
            this.lotQuantityET.Validating += new System.ComponentModel.CancelEventHandler(this.lotQuantityET_Validating);
            // 
            // lotDateEdit
            // 
            this.lotDateEdit.EditValue = null;
            this.lotDateEdit.Location = new System.Drawing.Point(142, 36);
            this.lotDateEdit.Name = "lotDateEdit";
            this.lotDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lotDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.lotDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lotDateEdit.Properties.MaskSettings.Set("mask", "g");
            this.lotDateEdit.Properties.UseMaskAsDisplayFormat = true;
            this.lotDateEdit.Size = new System.Drawing.Size(180, 22);
            this.lotDateEdit.TabIndex = 7;
            // 
            // AddLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 127);
            this.Controls.Add(this.lotDateEdit);
            this.Controls.Add(this.AddLotButton);
            this.Controls.Add(this.lotNumberET);
            this.Controls.Add(this.lotQuantityET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "AddLotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на партида";
            this.Load += new System.EventHandler(this.AddLotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotNumberET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotQuantityET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit lotQuantityET;
        private DevExpress.XtraEditors.TextEdit lotNumberET;
        private DevExpress.XtraEditors.SimpleButton AddLotButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.DateEdit lotDateEdit;
    }
}