using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereDesktop.Utils;

namespace WereDesktop.Forms
{
    public partial class AddBarcodeForm : XtraForm
    {
        private string ProductID;
        public AddBarcodeForm(string id)
        {
            InitializeComponent();
            this.ProductID = id;
        }

        private void addBarcodeButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool bValidBarcode = ValidateBarcode();

            if (bValidBarcode)
            {
                var barcodeNumber = barcodeNumberET.Text;

                using (var db = new WereDesktopEntities())
                {


                    Barcode barcode = new Barcode();
                    Guid id = Guid.NewGuid();

                    barcode.ID = id.ToString();
                    barcode.ProductID = ProductID;
                    barcode.BarcodeNumber = barcodeNumber;

                    db.Barcode.AddOrUpdate(barcode);

                    db.SaveChanges();

                    this.Close();

                }
            }
        }
        private void barcodeNumberET_Validating(object sender, CancelEventArgs e)
        {
            ValidateBarcode();
        }

        private bool ValidateBarcode()
        {
            var barcodeNumber = barcodeNumberET.Text;
            bool bStatus = true;
            if (barcodeNumberET.Text == "")
            {
                dxErrorProvider.SetError(barcodeNumberET, "Въведете баркод на продукта!");
                dxErrorProvider.SetIconAlignment(barcodeNumberET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(barcodeNumberET, null);
                dxErrorProvider.SetIconAlignment(barcodeNumberET, ErrorIconAlignment.MiddleRight);
                try
                {
                    if (!CheckBarcode.IsValidEan13(barcodeNumber))
                    {
                        dxErrorProvider.SetError(barcodeNumberET, "Моля въведете баркод отговарящ на стандарта EAN-13!");
                        dxErrorProvider.SetIconAlignment(barcodeNumberET, ErrorIconAlignment.MiddleRight);
                        bStatus = false;
                    }
                    using (var db = new WereDesktopEntities())
                    {
                        var barcodes = db.Barcode.Where(b => b.BarcodeNumber == barcodeNumber).ToList();
                        if (barcodes.Count > 0)
                        {
                            dxErrorProvider.SetError(barcodeNumberET, "Въведеният баркод вече съществува!");
                            dxErrorProvider.SetIconAlignment(barcodeNumberET, ErrorIconAlignment.MiddleRight);
                            bStatus = false;
                        }
                    }

                }
                catch
                {
                    dxErrorProvider.SetError(barcodeNumberET, "Моля въведете баркод отговарящ на стандарта EAN-13!");
                    dxErrorProvider.SetIconAlignment(barcodeNumberET, ErrorIconAlignment.MiddleRight);
                    bStatus = false;
                }
            }
            return bStatus;
        }
    }
}
