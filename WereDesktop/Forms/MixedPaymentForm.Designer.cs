
namespace WereDesktop.Forms
{
    partial class MixedPaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sumToPayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inCashET = new DevExpress.XtraEditors.TextEdit();
            this.addDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inCashET.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сума за пащане:";
            // 
            // sumToPayLabel
            // 
            this.sumToPayLabel.AutoSize = true;
            this.sumToPayLabel.Location = new System.Drawing.Point(133, 9);
            this.sumToPayLabel.Name = "sumToPayLabel";
            this.sumToPayLabel.Size = new System.Drawing.Size(42, 17);
            this.sumToPayLabel.TabIndex = 2;
            this.sumToPayLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "В брой:";
            // 
            // inCashET
            // 
            this.inCashET.Location = new System.Drawing.Point(136, 33);
            this.inCashET.Name = "inCashET";
            this.inCashET.Size = new System.Drawing.Size(125, 22);
            this.inCashET.TabIndex = 6;
            this.inCashET.TextChanged += new System.EventHandler(this.inCashET_TextChanged);
            // 
            // addDocumentButton
            // 
            this.addDocumentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addDocumentButton.Location = new System.Drawing.Point(0, 82);
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.Size = new System.Drawing.Size(349, 29);
            this.addDocumentButton.TabIndex = 7;
            this.addDocumentButton.Text = "Направи плащането";
            this.addDocumentButton.Click += new System.EventHandler(this.addDocumentButton_Click);
            // 
            // MixedPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 111);
            this.Controls.Add(this.addDocumentButton);
            this.Controls.Add(this.inCashET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumToPayLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::WereDesktop.Properties.Resources.were_black_53t_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MixedPaymentForm";
            this.Text = "Смесено плащане";
            this.Load += new System.EventHandler(this.MixedPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inCashET.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumToPayLabel;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit inCashET;
        private DevExpress.XtraEditors.SimpleButton addDocumentButton;
    }
}