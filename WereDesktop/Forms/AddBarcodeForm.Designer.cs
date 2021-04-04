
namespace WereDesktop.Forms
{
    partial class AddBarcodeForm
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
            this.addBarcodeButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.barcodeNumberET = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeNumberET.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на баркод:";
            // 
            // addBarcodeButton
            // 
            this.addBarcodeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addBarcodeButton.Location = new System.Drawing.Point(0, 60);
            this.addBarcodeButton.Name = "addBarcodeButton";
            this.addBarcodeButton.Size = new System.Drawing.Size(335, 29);
            this.addBarcodeButton.TabIndex = 2;
            this.addBarcodeButton.Text = "Добави";
            this.addBarcodeButton.Click += new System.EventHandler(this.addBarcodeButton_Click);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // barcodeNumberET
            // 
            this.barcodeNumberET.Location = new System.Drawing.Point(130, 10);
            this.barcodeNumberET.Name = "barcodeNumberET";
            this.barcodeNumberET.Size = new System.Drawing.Size(186, 22);
            this.barcodeNumberET.TabIndex = 1;
            this.barcodeNumberET.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeNumberET_Validating);
            // 
            // AddBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 89);
            this.Controls.Add(this.addBarcodeButton);
            this.Controls.Add(this.barcodeNumberET);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBarcodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на баркод";
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeNumberET.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit barcodeNumberET;
        private DevExpress.XtraEditors.SimpleButton addBarcodeButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}