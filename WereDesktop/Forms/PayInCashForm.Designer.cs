
namespace WereDesktop.Forms
{
    partial class PayInCashForm
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
            this.sumToPayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.inCashET = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.addDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.inCashET.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума за пащане:";
            // 
            // sumToPayLabel
            // 
            this.sumToPayLabel.AutoSize = true;
            this.sumToPayLabel.Location = new System.Drawing.Point(138, 13);
            this.sumToPayLabel.Name = "sumToPayLabel";
            this.sumToPayLabel.Size = new System.Drawing.Size(42, 17);
            this.sumToPayLabel.TabIndex = 1;
            this.sumToPayLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "В брой:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ресто:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(138, 71);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 17);
            this.changeLabel.TabIndex = 4;
            // 
            // inCashET
            // 
            this.inCashET.Location = new System.Drawing.Point(138, 40);
            this.inCashET.Name = "inCashET";
            this.inCashET.Size = new System.Drawing.Size(125, 22);
            this.inCashET.TabIndex = 5;
            this.inCashET.TextChanged += new System.EventHandler(this.inCashET_TextChanged);
            this.inCashET.Validating += new System.ComponentModel.CancelEventHandler(this.inCashET_Validating);
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // addDocumentButton
            // 
            this.addDocumentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addDocumentButton.Location = new System.Drawing.Point(0, 112);
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.Size = new System.Drawing.Size(322, 29);
            this.addDocumentButton.TabIndex = 6;
            this.addDocumentButton.Text = "Направи плащането";
            this.addDocumentButton.Click += new System.EventHandler(this.addDocumentButton_Click);
            // 
            // PayInCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 141);
            this.Controls.Add(this.addDocumentButton);
            this.Controls.Add(this.inCashET);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sumToPayLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayInCashForm";
            this.Text = "Плащане в брой";
            this.Load += new System.EventHandler(this.PayInCashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inCashET.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumToPayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label changeLabel;
        private DevExpress.XtraEditors.TextEdit inCashET;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.SimpleButton addDocumentButton;
    }
}