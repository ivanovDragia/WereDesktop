
namespace WereDesktop.Forms
{
    partial class EditProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameET = new DevExpress.XtraEditors.TextEdit();
            this.productPriceET = new DevExpress.XtraEditors.TextEdit();
            this.productNumberET = new DevExpress.XtraEditors.TextEdit();
            this.EditProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productNameET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumberET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер на продукт:";
            // 
            // productNameET
            // 
            this.productNameET.Location = new System.Drawing.Point(114, 12);
            this.productNameET.Name = "productNameET";
            this.productNameET.Size = new System.Drawing.Size(109, 22);
            this.productNameET.TabIndex = 5;
            this.productNameET.Validating += new System.ComponentModel.CancelEventHandler(this.productNameET_Validating);
            // 
            // productPriceET
            // 
            this.productPriceET.Location = new System.Drawing.Point(114, 40);
            this.productPriceET.Name = "productPriceET";
            this.productPriceET.Size = new System.Drawing.Size(109, 22);
            this.productPriceET.TabIndex = 7;
            this.productPriceET.Validating += new System.ComponentModel.CancelEventHandler(this.productPriceET_Validating);
            // 
            // productNumberET
            // 
            this.productNumberET.Location = new System.Drawing.Point(114, 68);
            this.productNumberET.Name = "productNumberET";
            this.productNumberET.Size = new System.Drawing.Size(109, 22);
            this.productNumberET.TabIndex = 8;
            this.productNumberET.Validating += new System.ComponentModel.CancelEventHandler(this.productNumberET_Validating);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditProductButton.Location = new System.Drawing.Point(0, 101);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(247, 29);
            this.EditProductButton.TabIndex = 9;
            this.EditProductButton.Text = "Редактирай";
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 130);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.productNumberET);
            this.Controls.Add(this.productPriceET);
            this.Controls.Add(this.productNameET);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактиране на продукт";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productNameET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumberET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit productNameET;
        private DevExpress.XtraEditors.TextEdit productPriceET;
        private DevExpress.XtraEditors.TextEdit productNumberET;
        private DevExpress.XtraEditors.SimpleButton EditProductButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}