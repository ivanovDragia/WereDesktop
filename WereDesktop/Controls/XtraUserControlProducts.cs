using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereDesktop.Forms;

namespace WereDesktop.Controls
{
    public partial class XtraUserControlProducts : XtraUserControl
    {
        private AddProductForm addProductForm;
        private EditProductForm editProductForm;
        private AddLotForm addLotForm;
        private EditLotForm editLotForm;
        private AddBarcodeForm addBarcodeForm;
        private EditBarcodeForm editBarcodeForm;

        public Product SelectedProduct => productGridView.GetFocusedRow() as Product;
        public Lot SelectedLot => lotGridView.GetFocusedRow() as Lot;
        public Barcode SelectedBarcode => barcodeGridView.GetFocusedRow() as Barcode;
        public XtraUserControlProducts()
        {
            InitializeComponent();

            using (var db = new WereDesktopEntities())
            {
                //db.Lot.Load();
                productBindingSource.DataSource = db.Product.Include(p => p.Lot).ToList();
            }
        }

        private void productGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selected = SelectedProduct;

            using (var db = new WereDesktopEntities())
            {
                lotBindingSource1.DataSource = db.Lot.Where(l => l.ProductID == selected.ID).ToList();
                barcodeBindingSource.DataSource = db.Barcode.Where(b => b.ProductID == selected.ID).ToList();
            }
        }

        #region Product CRUD
        private void addProductButton_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            editProduct();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        #endregion

        #region Lot CRUD
        private void addLotButton_Click(object sender, EventArgs e)
        {
            addLot();
        }

        private void editLotButton_Click(object sender, EventArgs e)
        {
            editLot();
        }

        private void deleteLotButton_Click(object sender, EventArgs e)
        {
            deleteLot();
        }

        #endregion

        #region Barcode CRUD
        private void addBarcodeButton_Click(object sender, EventArgs e)
        {
            addBarcode();
        }

        private void editBarcodeButton_Click(object sender, EventArgs e)
        {
            editBarcode();
        }

        private void deleteBarcodeButton_Click(object sender, EventArgs e)
        {
            deleteBarcode();
        }
        #endregion

        #region Shortcut keys
        private void productGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editProduct();
        }

        private void productGridControl_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                deleteProduct();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addProduct();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }
        }

        private void lotGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editLot();
        }

        private void lotGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteLot();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addLot();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }
        }

        private void barcodeGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteBarcode();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addBarcode();
            }
            else if (e.KeyCode == Keys.F5)
            {
                using (var db = new WereDesktopEntities())
                {
                    updateScreen(db);
                }
            }
        }

        private void barcodeGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editBarcode();
        }
        #endregion

        #region methods

        private void addProduct()
        {
            addProductForm = new AddProductForm();
            addProductForm.MaximizeBox = false;
            addProductForm.MinimizeBox = false;
            addProductForm.ShowDialog();

            using (var db = new WereDesktopEntities())
            {
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void editProduct()
        {
            var editProduct = SelectedProduct;
            editProductForm = new EditProductForm(editProduct);
            editProductForm.MaximizeBox = false;
            editProductForm.MinimizeBox = false;
            editProductForm.ShowDialog();

            using (var db = new WereDesktopEntities())
            {
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void deleteProduct()
        {
            var deleteProduct = SelectedProduct;

            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избрания продукт", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                using (var db = new WereDesktopEntities())
                {

                    if (deleteProduct != null)
                    {
                        foreach (var docRow in db.DocumentRow.Where(row => row.ProductID == deleteProduct.ID))
                        {
                            db.DocumentRow.Remove(docRow);
                        }
                        db.SaveChanges();

                        foreach (var lot in db.Lot.Where(l => l.ProductID == deleteProduct.ID).ToList())
                        {
                            db.Lot.Remove(lot);

                        }
                        db.SaveChanges();

                        foreach (var barcode in db.Barcode.Where(b => b.ProductID == deleteProduct.ID).ToList())
                        {
                            db.Barcode.Remove(barcode);

                        }
                        db.SaveChanges();



                        deleteProduct.DocumentRow = null;
                        deleteProduct.Lot = null;
                        deleteProduct.Barcode = null;

                        db.Product.Attach(deleteProduct);
                        db.Product.Remove(deleteProduct);
                        db.SaveChanges();

                        updateScreen(db);
                    }
                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void addLot()
        {
            var selected = SelectedProduct;
            addLotForm = new AddLotForm(selected.ID);
            addLotForm.MaximizeBox = false;
            addLotForm.MinimizeBox = false;
            addLotForm.ShowDialog();

            using (var db = new WereDesktopEntities())
            {
                lotBindingSource1.DataSource = db.Lot.Where(l => l.ProductID == selected.ID).ToList();
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void editLot()
        {
            var selectedProd = SelectedProduct;
            var selected = SelectedLot;
            editLotForm = new EditLotForm(selected);
            editLotForm.MaximizeBox = false;
            editLotForm.MinimizeBox = false;

            editLotForm.ShowDialog();

            using (var db = new WereDesktopEntities())
            {
                lotBindingSource1.DataSource = db.Lot.Where(l => l.ProductID == selectedProd.ID).ToList();
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void deleteLot()
        {
            var deleteLot = SelectedLot;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избраната партида?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                using (var db = new WereDesktopEntities())
                {

                    if (deleteLot != null)
                    {
                        foreach (var docRow in db.DocumentRow.Where(row => row.LotID == deleteLot.ID))
                        {
                            db.DocumentRow.Remove(docRow);
                        }
                        db.SaveChanges();

                        deleteLot.DocumentRow = null;

                        db.Lot.Attach(deleteLot);
                        db.Lot.Remove(deleteLot);
                        db.SaveChanges();

                        updateScreen(db);
                    }
                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void addBarcode()
        {
            var selected = SelectedProduct;
            addBarcodeForm = new AddBarcodeForm(selected.ID);
            addBarcodeForm.MaximizeBox = false;
            addBarcodeForm.MinimizeBox = false;
            addBarcodeForm.ShowDialog();


            using (var db = new WereDesktopEntities())
            {
                barcodeBindingSource.DataSource = db.Barcode.Where(b => b.ProductID == selected.ID).ToList();
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void editBarcode()
        {
            var selectedProd = SelectedProduct;
            var selected = SelectedBarcode;
            editBarcodeForm = new EditBarcodeForm(selected);
            editBarcodeForm.MaximizeBox = false;
            editBarcodeForm.MinimizeBox = false;
            editBarcodeForm.ShowDialog();


            using (var db = new WereDesktopEntities())
            {
                barcodeBindingSource.DataSource = db.Barcode.Where(b => b.ProductID == selectedProd.ID).ToList();
                productBindingSource.DataSource = db.Product.ToList();
            }

        }

        private void deleteBarcode()
        {
            var deleteBarcode = SelectedBarcode;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избрания баркод?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...
                using (var db = new WereDesktopEntities())
                {

                    if (deleteBarcode != null)
                    {

                        db.Barcode.Attach(deleteBarcode);
                        db.Barcode.Remove(deleteBarcode);
                        db.SaveChanges();

                        updateScreen(db);
                    }
                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void updateScreen(WereDesktopEntities db)
        {
            productBindingSource.DataSource = db.Product.ToList();

            var selected = SelectedProduct;

            lotBindingSource1.DataSource = db.Lot.Where(l => l.ProductID == selected.ID).ToList();
            barcodeBindingSource.DataSource = db.Barcode.Where(b => b.ProductID == selected.ID).ToList();
        }

        #endregion
    }
}
