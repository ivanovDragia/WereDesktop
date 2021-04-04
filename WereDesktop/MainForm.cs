using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WereDesktop.Controls;

namespace WereDesktop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string lastClicked;
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        public MainForm()
        {

            try
            {
                FluentSplashScreenOptions fluentSplashScreenOptions = new FluentSplashScreenOptions();
                fluentSplashScreenOptions.Title = "Were Desktop";
                fluentSplashScreenOptions.Subtitle = "";
                fluentSplashScreenOptions.RightFooter = "Starting....";
                fluentSplashScreenOptions.LeftFooter = $"Copyright 2021 {Environment.NewLine}All Rights reserved.";
                fluentSplashScreenOptions.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
                fluentSplashScreenOptions.OpacityColor = Color.FromArgb(0, 136, 202);
                fluentSplashScreenOptions.Opacity = 255;
                fluentSplashScreenOptions.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                SplashScreenManager.ShowFluentSplashScreen(fluentSplashScreenOptions, parentForm: this, useFadeIn: true, useFadeOut: true);

                InitializeComponent();
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //closing splash screen
                SplashScreenManager.CloseForm(false, 3000, this);
                Thread.Sleep(3800);
                this.WindowState = FormWindowState.Maximized;

            }

        }

        private void barButtonProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new XtraUserControlProducts { Dock = DockStyle.Fill });
            barButtonDocuments.Checked = false;
            barButtonContragents.Checked = false;
            barButtonCreateDocument.Checked = false;
            this.Text = "Продукти";
            lastClicked = "product";
            if (lastClicked.Equals("product"))
            {
                barButtonProduct.Checked = true;
            }
        }

        private void barButtonDocuments_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new XtraUserControlDocuments { Dock = DockStyle.Fill });
            barButtonProduct.Checked = false;
            barButtonContragents.Checked = false;
            barButtonCreateDocument.Checked = false;
            this.Text = "Документи";
            lastClicked = "documents";
            if (lastClicked.Equals("documents"))
            {
                barButtonDocuments.Checked = true;
            }
        }

        private void barButtonContragents_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new XtraUserControlContragents { Dock = DockStyle.Fill });
            barButtonProduct.Checked = false;
            barButtonDocuments.Checked = false;
            barButtonCreateDocument.Checked = false;
            this.Text = "Контрагенти";
            lastClicked = "contragents";
            if (lastClicked.Equals("contragents"))
            {
                barButtonContragents.Checked = true;
            }

        }

        private void barButtonCreateDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new XtraUserControlCreateDocument { Dock = DockStyle.Fill });
            barButtonProduct.Checked = false;
            barButtonDocuments.Checked = false;
            barButtonContragents.Checked = false;
            this.Text = "Създаване на документ";
            lastClicked = "createDocument";
            if (lastClicked.Equals("createDocument"))
            {
                barButtonCreateDocument.Checked = true;
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Were Desktop version v0.2", "Oтносно", MessageBoxButtons.OK);
        }
    }
}