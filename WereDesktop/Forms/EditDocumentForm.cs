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

namespace WereDesktop.Forms
{
    public partial class EditDocumentForm : XtraForm
    {
        string documentId;
        Document document=new Document();
        public EditDocumentForm(Document doc)
        {
            InitializeComponent();
            this.documentId = doc.ID;
            

            using (var db = new WereDesktopEntities())
            {
                editDocumentSourceLookUpEdit.Properties.DataSource = db.Contragent.ToList();
                editDocumentSourceLookUpEdit.EditValue = doc.SourceID;

                editDocumentDestinationLookUpEdit.Properties.DataSource = db.Contragent.ToList();
                editDocumentDestinationLookUpEdit.EditValue = doc.DestinationID;


                editDocumentNumberTE.Text = doc.DocumentNumber.ToString();
                editDocumentDateTE.Text = doc.Date.ToString();
                var documents = db.Document.Where(d => d.ID == documentId).ToList();
                foreach (Document d in documents)
                {
                    document = d;
                }
                
            }
            //CheckUserInput();
        }

        private void CheckUserInput()
        {
            throw new NotImplementedException();
        }

        private void editDocumentBtn_Click(object sender, EventArgs e)
        {
            document.DestinationID= editDocumentDestinationLookUpEdit.EditValue.ToString();
            document.SourceID = editDocumentSourceLookUpEdit.EditValue.ToString();

            using (var db = new WereDesktopEntities())
            {
                
                db.Document.AddOrUpdate(document);
                db.SaveChanges();
            }
        }
    }
}
