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

namespace WereDesktop.Forms
{
    public partial class EditDocumentRowForm : XtraForm
    {
        DocumentRow selectedRow;
        string documentId;
        Lot originalLot;
        Double originalQuantity;
        string originalLotId;
        public EditDocumentRowForm(DocumentRow row)
        {
            InitializeComponent();
            this.documentId = row.DocumentID;
            this.selectedRow = row;
            this.originalLotId = row.LotID;
            using (var db = new WereDesktopEntities())
            {
                editDocumentRowProductTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
                editDocumentRowProductTreeListLookUpEdit.EditValue = row.ProductID;
                editDocumentRowLotTreeListLookUpEdit.Properties.DataSource = db.Lot.Where(l => l.ProductID == row.ProductID).ToList();
                editDocumentRowLotTreeListLookUpEdit.EditValue = row.LotID;
                editDocumentRowQuantityTE.Text = row.Quantity.ToString();
                var lots = db.Lot.Where(l => l.ID == row.LotID).ToList();
                foreach (Lot lot in lots)
                {
                    originalLot = lot;
                }
                originalQuantity = row.Quantity;
            }
            CheckUserInput();
        }




        private void editDocumentRowProductTreeListLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (editDocumentRowProductTreeListLookUpEdit.EditValue != null)
            {
                var productID = editDocumentRowProductTreeListLookUpEdit.EditValue.ToString();
                using (var db = new WereDesktopEntities())
                {
                    editDocumentRowProductTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
                    editDocumentRowLotTreeListLookUpEdit.Properties.DataSource = db.Lot.Where(l => l.ProductID == productID).ToList();

                }
            }
            CheckUserInput();
        }

        private void editDocumentRowBtn_Click(object sender, EventArgs e)
        {
            var id = documentId;

            double quantity;
            double.TryParse(editDocumentRowQuantityTE.Text, out quantity);


            originalLot.Quantity = originalLot.Quantity + originalQuantity;
            using (var db = new WereDesktopEntities())
            {
                db.Lot.AddOrUpdate(originalLot);
                db.SaveChanges();
            }

            selectedRow.ProductID = editDocumentRowProductTreeListLookUpEdit.EditValue.ToString();
            selectedRow.LotID = editDocumentRowLotTreeListLookUpEdit.EditValue.ToString();
            selectedRow.Quantity = quantity;

            using (var db = new WereDesktopEntities())
            {
                var lotToUpdate = new Lot();

                var lots = db.Lot.Where(l => l.ID == selectedRow.LotID).ToList();
                foreach (Lot lot in lots)
                {
                    lotToUpdate = lot;
                }
                lotToUpdate.Quantity = lotToUpdate.Quantity - selectedRow.Quantity;

                selectedRow.Sum = Convert.ToDecimal(selectedRow.Quantity) * lotToUpdate.Product.Price;

                db.DocumentRow.AddOrUpdate(selectedRow);






                db.SaveChanges();
            }






        }

        private void CheckUserInput()
        {
            var isValid = true;

            var lot = editDocumentRowLotTreeListLookUpEdit.GetSelectedDataRow() as Lot;

            double? quantity = null;

            if (lot != null)
            {
                quantity = lot.Quantity;
            }

            isValid &= editDocumentRowProductTreeListLookUpEdit.CheckTextValue(dxErrorProvider, "Изберете продукт");
            isValid &= editDocumentRowLotTreeListLookUpEdit.CheckTextValue(dxErrorProvider, "Изберете партида");
            var testLotID = editDocumentRowLotTreeListLookUpEdit.EditValue.ToString();
            if (originalLotId.Equals(testLotID))
            {
                isValid &= editDocumentRowQuantityTE.CheckLotValue(quantity + originalQuantity, dxErrorProvider, "Изберете валидно количество");
            }
            else 
            {
                isValid &= editDocumentRowQuantityTE.CheckLotValue(quantity, dxErrorProvider, "Изберете валидно количество");

            }

            editDocumentRowBtn.Enabled = isValid;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            CheckUserInput();
        }
    }
}
