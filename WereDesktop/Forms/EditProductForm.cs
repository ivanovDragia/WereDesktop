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
    public partial class EditProductForm : XtraForm
    {
        private Product Product;
        public EditProductForm(Product product)
        {
            InitializeComponent();
            this.Product = product;
        }
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            productNameET.Text = Product.Name;
            productPriceET.Text = Product.Price.ToString();
            productNumberET.Text = Product.ProductNumber;
        }
        private void EditProductButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void ValidateForm()
        {
            bool bValidName = ValidateProductName();
            bool bValidPrice = ValidateProductPrice();
            bool bValidNumber = ValidateProductNumber();
            if (bValidName && bValidPrice && bValidNumber)
            {
                if (Product.ID != null)
                {

                    var id = Product.ID;

                    var name = productNameET.Text;

                    var price = Convert.ToDecimal(productPriceET.Text);

                    var productNumber = productNumberET.Text;

                    using (var db = new WereDesktopEntities())
                    {
                        Product prod = new Product();

                        prod.ID = id.ToString();
                        prod.Name = name;
                        prod.ProductNumber = productNumber;
                        prod.Price = price;


                        db.Product.AddOrUpdate(prod);

                        db.SaveChanges();
                        this.Close();

                    }
                }
            }
        }
        private void productNameET_Validating(object sender, CancelEventArgs e)
        {
            ValidateProductName();
        }
        private void productPriceET_Validating(object sender, CancelEventArgs e)
        {
            ValidateProductPrice();
        }
        private void productNumberET_Validating(object sender, CancelEventArgs e)
        {
            ValidateProductNumber();
        }
        private bool ValidateProductName()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(productNameET.Text))
            {
                dxErrorProvider.SetError(productNameET, "Въвъдете име на продукта!");
                dxErrorProvider.SetIconAlignment(productNameET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(productNameET, null);
                dxErrorProvider.SetIconAlignment(productNameET, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }
        private bool ValidateProductPrice()
        {

            bool bStatus = true;
            if (productPriceET.Text == "")
            {
                dxErrorProvider.SetError(productPriceET, "Въведете цена на продукта!");
                dxErrorProvider.SetIconAlignment(productPriceET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(productPriceET, null);
                dxErrorProvider.SetIconAlignment(productPriceET, ErrorIconAlignment.MiddleRight);
                try
                {
                    decimal price = decimal.Parse(productPriceET.Text);
                    dxErrorProvider.SetError(productPriceET, null);
                    dxErrorProvider.SetIconAlignment(productPriceET, ErrorIconAlignment.MiddleRight);
                }
                catch
                {
                    dxErrorProvider.SetError(productPriceET, "Моля въведете число за цена на продукта!");
                    dxErrorProvider.SetIconAlignment(productPriceET, ErrorIconAlignment.MiddleRight);
                    bStatus = false;
                }
            }
            return bStatus;

        }
        private bool ValidateProductNumber()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(productNumberET.Text))
            {
                dxErrorProvider.SetError(productNumberET, "Въвъдете номер на продукта!");
                dxErrorProvider.SetIconAlignment(productNumberET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(productNumberET, null);
                dxErrorProvider.SetIconAlignment(productNumberET, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }
    }
}
