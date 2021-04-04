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
    public partial class AddProductToDocumentRowForm : XtraForm
    {
        private Product prod;
        private List<Classes.DocumentRowCart> documentRowsList = new List<Classes.DocumentRowCart>();
        public AddProductToDocumentRowForm(List<Classes.DocumentRowCart> list)
        {
            this.documentRowsList = list;
            InitializeComponent();
            using (var db = new WereDesktopEntities())
            {
                productTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
            }
            CheckUserInput();
        }

        public AddProductToDocumentRowForm(List<Classes.DocumentRowCart> list, Product product)
        {
            this.documentRowsList = list;
            this.prod = product;
            InitializeComponent();
            using (var db = new WereDesktopEntities())
            {
                productTreeListLookUpEdit.Properties.DataSource = db.Product.ToList();
            }
            if (prod != null)
            {
                productTreeListLookUpEdit.EditValue = prod;

            }
            CheckUserInput();
        }
        private void AddProductToDocumentRowForm_Load(object sender, EventArgs e)
        {
            if (prod != null)
            {
                productTreeListLookUpEdit.EditValue = prod.ID;

            }
        }

        private void productTreeListLookUpEdit_Properties_EditValueChanged(object sender, EventArgs e)
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

        private void AddDocumentRowButton_Click(object sender, EventArgs e)
        {

            double quantity = double.Parse(quantityET.Text);

            var productID = productTreeListLookUpEdit.EditValue.ToString();
            var lotID = lotTreeListLookUpEdit.EditValue.ToString();

            using (var db = new WereDesktopEntities())
            {
                var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                foreach (Lot lot in lots)
                {
                    var products = db.Product.Where(p => p.ID == productID).ToList();
                    foreach (Product product in products)
                    {

                        if (lot.ID.Equals(lotID))
                        {
                            quantity = Convert.ToDouble(quantityET.Text);
                        }
                        DocumentRowCart dr = new DocumentRowCart();
                        Guid id = Guid.NewGuid();

                        dr.ID = id.ToString();
                        dr.ProductID = productID;
                        dr.ProductName = product.Name;
                        dr.LotID = lotID;
                        dr.LotNumber = lot.LotNumber;
                        dr.Quantity = quantity;
                        dr.Sum = Convert.ToDecimal(quantity) * lot.Product.Price;
                        var lot1 = lotTreeListLookUpEdit.GetSelectedDataRow() as Lot;


                        db.SaveChanges();

                        lot.Quantity = lot.Quantity - quantity;


                        db.Lot.AddOrUpdate(lot);

                        db.SaveChanges();

                        documentRowsList.Add(dr);
                        this.Close();
                    }
                }
            }
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
            isValid &= quantityET.CheckLotValue(quantity, dxErrorProvider, "Изберете количество");

            AddDocumentRowButton.Enabled = isValid;
        }
        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            CheckUserInput();
        }
    }
}
