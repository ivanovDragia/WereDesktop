
namespace WereDesktop.Forms
{
    partial class AddContragentForm
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
            this.addContragentNameLabel = new System.Windows.Forms.Label();
            this.addContragentBulstatLabel = new System.Windows.Forms.Label();
            this.addContragentVatNumberLabel = new System.Windows.Forms.Label();
            this.addContragentCityLabel = new System.Windows.Forms.Label();
            this.addContragentAdressLabel = new System.Windows.Forms.Label();
            this.addContragentMrpLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addContragentBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addContragentPhoneNumberTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentMrpTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentAddressTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentCityTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentVatNumberTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentBulstatTE = new DevExpress.XtraEditors.TextEdit();
            this.addContragentNameTE = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addContragentPhoneNumberTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentMrpTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentAddressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentCityTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentVatNumberTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentBulstatTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // addContragentNameLabel
            // 
            this.addContragentNameLabel.AutoSize = true;
            this.addContragentNameLabel.Location = new System.Drawing.Point(12, 9);
            this.addContragentNameLabel.Name = "addContragentNameLabel";
            this.addContragentNameLabel.Size = new System.Drawing.Size(38, 17);
            this.addContragentNameLabel.TabIndex = 0;
            this.addContragentNameLabel.Text = "Име:";
            // 
            // addContragentBulstatLabel
            // 
            this.addContragentBulstatLabel.AutoSize = true;
            this.addContragentBulstatLabel.Location = new System.Drawing.Point(12, 37);
            this.addContragentBulstatLabel.Name = "addContragentBulstatLabel";
            this.addContragentBulstatLabel.Size = new System.Drawing.Size(67, 17);
            this.addContragentBulstatLabel.TabIndex = 1;
            this.addContragentBulstatLabel.Text = "Булстат:";
            // 
            // addContragentVatNumberLabel
            // 
            this.addContragentVatNumberLabel.AutoSize = true;
            this.addContragentVatNumberLabel.Location = new System.Drawing.Point(12, 65);
            this.addContragentVatNumberLabel.Name = "addContragentVatNumberLabel";
            this.addContragentVatNumberLabel.Size = new System.Drawing.Size(81, 17);
            this.addContragentVatNumberLabel.TabIndex = 2;
            this.addContragentVatNumberLabel.Text = "ВАТ номер:";
            // 
            // addContragentCityLabel
            // 
            this.addContragentCityLabel.AutoSize = true;
            this.addContragentCityLabel.Location = new System.Drawing.Point(12, 93);
            this.addContragentCityLabel.Name = "addContragentCityLabel";
            this.addContragentCityLabel.Size = new System.Drawing.Size(43, 17);
            this.addContragentCityLabel.TabIndex = 3;
            this.addContragentCityLabel.Text = "Град:";
            // 
            // addContragentAdressLabel
            // 
            this.addContragentAdressLabel.AutoSize = true;
            this.addContragentAdressLabel.Location = new System.Drawing.Point(12, 121);
            this.addContragentAdressLabel.Name = "addContragentAdressLabel";
            this.addContragentAdressLabel.Size = new System.Drawing.Size(51, 17);
            this.addContragentAdressLabel.TabIndex = 4;
            this.addContragentAdressLabel.Text = "Адрес:";
            // 
            // addContragentMrpLabel
            // 
            this.addContragentMrpLabel.AutoSize = true;
            this.addContragentMrpLabel.Location = new System.Drawing.Point(12, 149);
            this.addContragentMrpLabel.Name = "addContragentMrpLabel";
            this.addContragentMrpLabel.Size = new System.Drawing.Size(42, 17);
            this.addContragentMrpLabel.TabIndex = 5;
            this.addContragentMrpLabel.Text = "МОЛ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Телефон:";
            // 
            // addContragentBtn
            // 
            this.addContragentBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addContragentBtn.Location = new System.Drawing.Point(0, 213);
            this.addContragentBtn.Name = "addContragentBtn";
            this.addContragentBtn.Size = new System.Drawing.Size(250, 29);
            this.addContragentBtn.TabIndex = 14;
            this.addContragentBtn.Text = "Добави";
            this.addContragentBtn.Click += new System.EventHandler(this.addContragentBtn_Click);
            // 
            // addContragentPhoneNumberTE
            // 
            this.addContragentPhoneNumberTE.Location = new System.Drawing.Point(99, 172);
            this.addContragentPhoneNumberTE.Name = "addContragentPhoneNumberTE";
            this.addContragentPhoneNumberTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentPhoneNumberTE.TabIndex = 13;
            this.addContragentPhoneNumberTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentPhoneNumberTE_Validating);
            // 
            // addContragentMrpTE
            // 
            this.addContragentMrpTE.Location = new System.Drawing.Point(99, 144);
            this.addContragentMrpTE.Name = "addContragentMrpTE";
            this.addContragentMrpTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentMrpTE.TabIndex = 12;
            this.addContragentMrpTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentMrpTE_Validating);
            // 
            // addContragentAddressTE
            // 
            this.addContragentAddressTE.Location = new System.Drawing.Point(99, 116);
            this.addContragentAddressTE.Name = "addContragentAddressTE";
            this.addContragentAddressTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentAddressTE.TabIndex = 11;
            this.addContragentAddressTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentAddressTE_Validating);
            // 
            // addContragentCityTE
            // 
            this.addContragentCityTE.Location = new System.Drawing.Point(99, 88);
            this.addContragentCityTE.Name = "addContragentCityTE";
            this.addContragentCityTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentCityTE.TabIndex = 10;
            this.addContragentCityTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentCityTE_Validating);
            // 
            // addContragentVatNumberTE
            // 
            this.addContragentVatNumberTE.Location = new System.Drawing.Point(99, 60);
            this.addContragentVatNumberTE.Name = "addContragentVatNumberTE";
            this.addContragentVatNumberTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentVatNumberTE.TabIndex = 9;
            this.addContragentVatNumberTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentVatNumberTE_Validating);
            // 
            // addContragentBulstatTE
            // 
            this.addContragentBulstatTE.Location = new System.Drawing.Point(99, 32);
            this.addContragentBulstatTE.Name = "addContragentBulstatTE";
            this.addContragentBulstatTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentBulstatTE.TabIndex = 8;
            this.addContragentBulstatTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentBulstatTE_Validating);
            // 
            // addContragentNameTE
            // 
            this.addContragentNameTE.Location = new System.Drawing.Point(99, 4);
            this.addContragentNameTE.Name = "addContragentNameTE";
            this.addContragentNameTE.Size = new System.Drawing.Size(125, 22);
            this.addContragentNameTE.TabIndex = 7;
            this.addContragentNameTE.Validating += new System.ComponentModel.CancelEventHandler(this.addContragentNameTE_Validating);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // AddContragentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 242);
            this.Controls.Add(this.addContragentBtn);
            this.Controls.Add(this.addContragentPhoneNumberTE);
            this.Controls.Add(this.addContragentMrpTE);
            this.Controls.Add(this.addContragentAddressTE);
            this.Controls.Add(this.addContragentCityTE);
            this.Controls.Add(this.addContragentVatNumberTE);
            this.Controls.Add(this.addContragentBulstatTE);
            this.Controls.Add(this.addContragentNameTE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addContragentMrpLabel);
            this.Controls.Add(this.addContragentAdressLabel);
            this.Controls.Add(this.addContragentCityLabel);
            this.Controls.Add(this.addContragentVatNumberLabel);
            this.Controls.Add(this.addContragentBulstatLabel);
            this.Controls.Add(this.addContragentNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "AddContragentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на контрагент";
            ((System.ComponentModel.ISupportInitialize)(this.addContragentPhoneNumberTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentMrpTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentAddressTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentCityTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentVatNumberTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentBulstatTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContragentNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addContragentNameLabel;
        private System.Windows.Forms.Label addContragentBulstatLabel;
        private System.Windows.Forms.Label addContragentVatNumberLabel;
        private System.Windows.Forms.Label addContragentCityLabel;
        private System.Windows.Forms.Label addContragentAdressLabel;
        private System.Windows.Forms.Label addContragentMrpLabel;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit addContragentNameTE;
        private DevExpress.XtraEditors.TextEdit addContragentBulstatTE;
        private DevExpress.XtraEditors.TextEdit addContragentVatNumberTE;
        private DevExpress.XtraEditors.TextEdit addContragentCityTE;
        private DevExpress.XtraEditors.TextEdit addContragentAddressTE;
        private DevExpress.XtraEditors.TextEdit addContragentMrpTE;
        private DevExpress.XtraEditors.TextEdit addContragentPhoneNumberTE;
        private DevExpress.XtraEditors.SimpleButton addContragentBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}