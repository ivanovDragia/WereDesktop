using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using WereDesktop.Classes;

namespace WereDesktop.Forms
{
    public partial class AddDocumentRowForm : XtraForm
    {
        private string DocumentID;
        public AddDocumentRowForm(string id)
        {
            InitializeComponent();
            this.DocumentID = id;

            using (var db = new WereDesktopEntities())
            {
                productTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
                lotTreeListLookUpEdit.Properties.DataSource = db.Lot.ToList();

            }

            CheckUserInput();
        }

        private void CheckUserInput()
        {
            var isValid = true;

            var lot = lotTreeListLookUpEdit.GetSelectedDataRow() as Lot;

            double? quantity = null;

            if (lot != null)
            {
                quantity = lot.Quantity;
            }

            isValid &= productTreeListLookUpEdit.CheckTextValue(dxErrorProvider, "Изберете продукт");
            isValid &= lotTreeListLookUpEdit.CheckTextValue(dxErrorProvider, "Изберете партида");
            isValid &= quantityET.CheckLotValue(quantity, dxErrorProvider, "Изберете валидно количество");

            AddDocumentRowButton.Enabled = isValid;
        }

        private void AddDocumentRowButton_Click(object sender, EventArgs e)
        {


            double quantity=double.Parse(quantityET.Text);

            var productID = productTreeListLookUpEdit.EditValue.ToString();
            var lotID = lotTreeListLookUpEdit.EditValue.ToString();

            using (var db = new WereDesktopEntities())
            {
                var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                foreach (Lot lot in lots)
                {
                    DocumentRow dr = new DocumentRow();
                    Guid id = Guid.NewGuid();

                    dr.ID = id.ToString();
                    dr.ProductID = productID;
                    dr.LotID = lotID;
                    dr.Quantity = quantity;
                    dr.Sum = Convert.ToDecimal(quantity) * lot.Product.Price;
                    dr.DocumentID = DocumentID;

                    lot.Quantity = lot.Quantity - quantity;

                    db.DocumentRow.AddOrUpdate(dr);
                    db.Lot.AddOrUpdate(lot);

                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            CheckUserInput();
        }

        private void productTreeListLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (productTreeListLookUpEdit.EditValue != null)
            {
                var productID = productTreeListLookUpEdit.EditValue.ToString();
                using (var db = new WereDesktopEntities())
                {
                    productTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
                    lotTreeListLookUpEdit.Properties.DataSource = db.Lot.Where(l => l.ProductID == productID).ToList();

                }
            }
        }
    }
}
