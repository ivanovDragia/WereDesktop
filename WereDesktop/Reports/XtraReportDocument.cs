using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WereDesktop.Classes;

namespace WereDesktop.Reports
{
    public partial class XtraReportDocument : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal sum;
        public XtraReportDocument(Document document, List<DocumentRowCart> list)
        {
            InitializeComponent();
            xrSourceContragentName.Text = document.Contragent.Name;
            xrSourceContragentBulstat.Text = document.Contragent.Bulstat;
            xrSourceContragentVATNumber.Text = document.Contragent.VatNumber;
            xrSourceContragentAddress.Text = document.Contragent.Address;
            xrSourceContragentCity.Text = document.Contragent.City;
            xrSourceContragentMrp.Text = document.Contragent.Mrp;
            xrSourceContragentPhoneNumber.Text = document.Contragent.PhoneNumber;

            xrDestinationContragentName.Text = document.Contragent1.Name;
            xrDestinationContragentBulstat.Text = document.Contragent1.Bulstat;
            xrDestinationContragentVATNumber.Text = document.Contragent1.VatNumber;
            xrDestinationContragentAddress.Text = document.Contragent1.Address;
            xrDestinationContragentCity.Text = document.Contragent1.City;
            xrDestinationContragentMrp.Text = document.Contragent1.Mrp;
            xrDestinationContragentPhoneNumber.Text = document.Contragent1.PhoneNumber;

            using (var db = new WereDesktopEntities())
            {
                objectDataSource3.DataSource = list;
            }

            foreach(DocumentRowCart dr in list)
            {
                sum += dr.Sum;
            }
            sumWithoutDDS.Text = sum.ToString();
            sumWithDDS.Text = (decimal.ToDouble(sum) * 1.2).ToString();
            
        }

        public static void ShowPreview(Document document, List<DocumentRowCart> list) {
            new XtraReportDocument(document,list).ShowPreview();
        }

    }
}
