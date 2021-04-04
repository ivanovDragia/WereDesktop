using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereDesktop.Classes;
using WereDesktop.Forms;
using WereDesktop.Reports;

namespace WereDesktop.Controls
{
    public partial class XtraUserControlDocuments : DevExpress.XtraEditors.XtraUserControl
    {

        private AddDocumentRowForm addDocumentRowForm;
        private EditDocumentRowForm editDocumentRowForm;
        private EditDocumentForm editDocumentForm;

        public Document SelectedDocument => documentGridView.GetFocusedRow() as Document;
        public DocumentRow SelectedDocumentRow => documentRowsGridView.GetFocusedRow() as DocumentRow;
        public XtraUserControlDocuments()
        {
            InitializeComponent();
            using (var db = new WereDesktopEntities())
            {
                documentBindingSource.DataSource = db.Document.Include(d => d.Contragent).Include(d => d.Contragent1).ToList();
            }
        }

        private void documentGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selected = SelectedDocument;

            using (var db = new WereDesktopEntities())
            {
                documentRowBindingSource.DataSource = db.DocumentRow.Include(dr => dr.Product).Include(dr => dr.Lot).Where(dr => dr.DocumentID == selected.ID).ToList();
                documentPaymentBindingSource.DataSource = db.DocumentPayment.Where(dp => dp.DocumentId == selected.ID).ToList();
            }
        }

        private void updateScreen(WereDesktopEntities db)
        {
            documentBindingSource.DataSource = db.Document.Include(d => d.Contragent).Include(d => d.Contragent1).ToList();

            var selected = SelectedDocument;

            documentRowBindingSource.DataSource = db.DocumentRow.Where(dr => dr.DocumentID == selected.ID).ToList();
            documentPaymentBindingSource.DataSource = db.DocumentPayment.Where(dp => dp.DocumentId == selected.ID).ToList();
        }

        private void editDocumentButton_Click(object sender, EventArgs e)
        {
            editDocument();
        }

        private void deleteDocumentButton_Click(object sender, EventArgs e)
        {
            deleteDocument();
        }

        private void addDocumentRowButton_Click(object sender, EventArgs e)
        {
            addDocumentRow();
        }

        private void editDocumentRowButton_Click(object sender, EventArgs e)
        {
            editDocumentRow();
        }

        private void deleteDocumentRowButton_Click(object sender, EventArgs e)
        {
            deleteDocumentRow();
        }

        private void documentsGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteDocument();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }
        }

        private void documentsGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editDocument();
        }

        private void deleteDocument()
        {
            var documentToDelete = SelectedDocument;
            if (documentToDelete != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected entry?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var db = new WereDesktopEntities())
                    {
                        var rowsToDelete = db.DocumentRow.Where(r => r.DocumentID == documentToDelete.ID).ToList();
                        var paymentsToDelete = db.DocumentPayment.Where(p => p.DocumentId == documentToDelete.ID).ToList();

                        foreach (DocumentPayment p in paymentsToDelete)
                        {

                            db.DocumentPayment.Attach(p);
                            db.DocumentPayment.Remove(p);
                            db.SaveChanges();

                        }

                        foreach (DocumentRow r in rowsToDelete)
                        {

                            using (var dbForLotUpdate = new WereDesktopEntities())
                            {
                                Lot lotToUpdate = new Lot();
                                var lots = dbForLotUpdate.Lot.Where(l => l.ID == r.LotID).ToList();
                                foreach (Lot lot in lots)
                                {
                                    lotToUpdate = lot;
                                }
                                lotToUpdate.Quantity += r.Quantity;

                                dbForLotUpdate.Lot.AddOrUpdate(lotToUpdate);
                                dbForLotUpdate.SaveChanges();

                                db.DocumentRow.Attach(r);
                                db.DocumentRow.Remove(r);
                                db.SaveChanges();
                            }


                        }
                        using (var bd = new WereDesktopEntities())
                        {
                            var docs = bd.Document.Where(d => d.ID == documentToDelete.ID).ToList();
                            foreach (Document d in docs)
                            {
                                bd.Document.Attach(d);
                                bd.Document.Remove(d);
                                bd.SaveChanges();
                            }

                        }
                    }
                    using (var db = new WereDesktopEntities())
                    {
                        updateScreen(db);
                    }
                }
            }


        }

        private void editDocument()
        {
            editDocumentForm = new EditDocumentForm(SelectedDocument);
            editDocumentForm.MaximizeBox = false;
            editDocumentForm.MinimizeBox = false;
            if (editDocumentForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }

            }
        }

        private void documentRowsGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editDocumentRow();
        }

        private void documentRowsGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteDocumentRow();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addDocumentRow();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }
        }

        private void deleteDocumentRow()
        {
            using (var db = new WereDesktopEntities())
            {
                var rowToDelete = SelectedDocumentRow;


                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected entry?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (rowToDelete != null)
                    {
                        using (var bd = new WereDesktopEntities())
                        {
                            Lot lotToUpdate = new Lot();
                            var lots = bd.Lot.Where(l => l.ID == rowToDelete.LotID).ToList();
                            foreach (Lot lot in lots)
                            {
                                lotToUpdate = lot;
                            }

                            lotToUpdate.Quantity += rowToDelete.Quantity;
                            bd.Lot.AddOrUpdate(lotToUpdate);
                            bd.SaveChanges();
                        }


                        //var rows = db.DocumentRow.Where(r => r.ID == rowToDelete.LotID).ToList();
                        //foreach (DocumentRow row in rows)
                        //{
                        //rowToDelete = row;
                        //}

                        db.DocumentRow.Attach(rowToDelete);
                        db.DocumentRow.Remove(rowToDelete);
                        db.SaveChanges();
                        updateScreen(db);
                    }
                }

            }

        }

        private void addDocumentRow()
        {

            var selected = SelectedDocument;
            addDocumentRowForm = new AddDocumentRowForm(selected.ID);
            addDocumentRowForm.MaximizeBox = false;
            addDocumentRowForm.MinimizeBox = false;


            if (addDocumentRowForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }

            }

        }

        private void editDocumentRow()
        {
            editDocumentRowForm = new EditDocumentRowForm(SelectedDocumentRow);
            editDocumentRowForm.MaximizeBox = false;
            editDocumentRowForm.MinimizeBox = false;
            if (editDocumentRowForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }

            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var selected = SelectedDocument;
            List<DocumentRowCart> list = new List<DocumentRowCart>();
            using (var db = new WereDesktopEntities())
            {
                foreach (DocumentRow dr in db.DocumentRow.Where(dr => dr.DocumentID == selected.ID).ToList())
                {
                    DocumentRowCart cardRow = new DocumentRowCart();
                    cardRow.ID = dr.ID;
                    cardRow.ProductID = dr.ProductID;
                    cardRow.ProductName = dr.Product.Name;
                    cardRow.LotID = dr.LotID;
                    cardRow.LotNumber = dr.Lot.LotNumber;
                    cardRow.Quantity = dr.Quantity;
                    cardRow.Sum = dr.Sum;

                    list.Add(cardRow);
                }
            }

            XtraReportDocument.ShowPreview(selected, list);
        }
        ToolTip t1 = new ToolTip();
        private void reportButton_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Справка за документ", reportButton);
        }
    }
}
