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
using WereDesktop.Forms;

namespace WereDesktop.Controls
{
    public partial class XtraUserControlContragents : DevExpress.XtraEditors.XtraUserControl
    {
        private AddContragentForm addForm;
        private EditContragentForm editForm;
        public Contragent SelectedContragent => contragentsGridView.GetFocusedRow() as Contragent;

        public XtraUserControlContragents()
        {
            InitializeComponent();

            using (var db = new WereDesktopEntities())
            {
                contragentBindingSource.DataSource = db.Contragent.ToList();
            }
        }

        private void addContragentButton_Click(object sender, EventArgs e)
        {
            addContragent();
        }

        private void editContragentButton_Click(object sender, EventArgs e)
        {
            editContragent();
        }

        private void deleteContragentButton_Click(object sender, EventArgs e)
        {
            deleteContragent();
        }

        private void addContragent()
        {
            addForm = new AddContragentForm();
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.ShowDialog();

            using (var db = new WereDesktopEntities())
            {
                contragentBindingSource.DataSource = db.Contragent.ToList();
            }

        }

        private void editContragent()
        {
            editForm = new EditContragentForm(SelectedContragent);
            editForm.MaximizeBox = false;
            editForm.MinimizeBox = false;
            

            if (editForm.ShowDialog() == DialogResult.OK) 
            {
                using (var db = new WereDesktopEntities())
                {
                    contragentBindingSource.DataSource = db.Contragent.ToList();
                }
            }
        }

        private void deleteContragent()
        {
            using (var db = new WereDesktopEntities())
            {
                var contragentToDelete = SelectedContragent;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete selected entry?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (contragentToDelete != null)
                    {
                        foreach (var doc in db.Document.Where(d => d.SourceID == contragentToDelete.ID || d.DestinationID == contragentToDelete.ID))
                        {
                            foreach (var payment in db.DocumentPayment.Where(p => p.DocumentId == doc.ID).ToList())
                            {
                                db.DocumentPayment.Remove(payment);

                            }


                            foreach (var row in db.DocumentRow.Where(r => r.DocumentID == doc.ID).ToList())
                            {
                                

                                using (var dbForLotUpdate = new WereDesktopEntities())
                                {
                                    Lot lotToUpdate = new Lot();
                                    var lots = dbForLotUpdate.Lot.Where(l => l.ID == row.LotID).ToList();
                                    foreach (Lot lot in lots)
                                    {
                                        lotToUpdate = lot;
                                    }
                                    lotToUpdate.Quantity += row.Quantity;

                                    dbForLotUpdate.Lot.AddOrUpdate(lotToUpdate);
                                    dbForLotUpdate.SaveChanges();
                                }
                                db.DocumentRow.Remove(row);
                            }


                            doc.DocumentPayment = null;
                            doc.DocumentRow = null;

                            db.Document.Remove(doc);


                        }
                        db.SaveChanges();
                        contragentToDelete.Document = null;
                        contragentToDelete.Document1 = null;

                        db.Contragent.Attach(contragentToDelete);
                        db.Contragent.Remove(contragentToDelete);
                        db.SaveChanges();
                        updateScreen(db);



                    }
                }
            }
        }

        private void updateScreen(WereDesktopEntities db)
        {
            contragentBindingSource.DataSource = db.Contragent.ToList();

            var selected = SelectedContragent;

            contragentBindingSource.DataSource = db.Contragent.ToList();
        }

        private void contragentsGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteContragent();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addContragent();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }

        }

        private void contragentsGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editContragent();
        }
    }
}
