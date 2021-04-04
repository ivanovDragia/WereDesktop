using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereDesktop.Classes;
using WereDesktop.Utils;

namespace WereDesktop.Forms
{
    public partial class PayInCashForm : XtraForm
    {
        private List<Classes.DocumentRowCart> documentRowsList = new List<Classes.DocumentRowCart>();
        private decimal sum;
        public PayInCashForm(List<Classes.DocumentRowCart> list, decimal sum)
        {
            this.documentRowsList = list;
            this.sum = sum;
            InitializeComponent();
        }
        private void PayInCashForm_Load(object sender, EventArgs e)
        {
            sumToPayLabel.Text = sum.ToString();
        }

        private void inCashET_Validating(object sender, CancelEventArgs e)
        {

        }

        private void inCashET_TextChanged(object sender, EventArgs e)
        {
            if (inCashET.Text != "")
            {
                try
                {
                    decimal input = decimal.Parse(inCashET.Text);
                    changeLabel.Text = (input - sum).ToString();
                }
                catch
                {
                    MessageBox.Show("problem pri izchislqvaneto");
                }
            }
        }

        private void addDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal input = decimal.Parse(inCashET.Text);
                if (input >= sum)
                {
                    using (var db = new WereDesktopEntities())
                    {
                        Document document = new Document();
                        Guid id = Guid.NewGuid();

                        document.ID = id.ToString();
                        document.SourceID = SelectedContragent.SourceContragentID;
                        document.DestinationID = SelectedContragent.contragent.ID;
                        document.DocumentNumber = GenerateDocumentNumber.generateDocumentNumber();
                        document.Date = DateTime.Now;

                        db.Document.AddOrUpdate(document);

                        db.SaveChanges();

                        foreach(DocumentRowCart dr in documentRowsList)
                        {
                            DocumentRow docRow = new DocumentRow();
                            docRow.ID = dr.ID;
                            docRow.ProductID = dr.ProductID;
                            docRow.LotID = dr.LotID;
                            docRow.Quantity = dr.Quantity;
                            docRow.Sum = dr.Sum;
                            docRow.DocumentID = document.ID;

                            db.DocumentRow.Add(docRow);

                            db.SaveChanges();
                        }

                        DocumentPayment dp = new DocumentPayment();
                        id = Guid.NewGuid();

                        dp.ID = id.ToString();
                        dp.DocumentId = document.ID;
                        dp.MethodOfPayment = "cash";
                        dp.Price = sum;

                        db.DocumentPayment.Add(dp);

                        db.SaveChanges();

                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
