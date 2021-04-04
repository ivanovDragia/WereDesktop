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
    public partial class EditLotForm : XtraForm
    {
        private Lot Lot;
        public EditLotForm(Lot lot)
        {
            InitializeComponent();
            this.Lot = lot;
        }
        private void EditLotForm_Load(object sender, EventArgs e)
        {
            lotQuantityET.Text = Lot.Quantity.ToString();
            lotDateEdit.EditValue = Lot.ExpirationDate;
            lotNumberET.Text = Lot.LotNumber;
        }
        private void EditLotButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void ValidateForm()
        {
            bool bValidQuantity = ValidateLotQuantity();
            bool bValidDate = ValidateLotDate();
            bool bValidNumber = ValidateLotNumber();
            if (bValidQuantity && bValidDate && bValidNumber)
            {
                if (Lot.ID != null)
                {
                    var id = Lot.ID;

                    double quantity = Convert.ToDouble(lotQuantityET.Text);

                    var date = DateTime.Parse(lotDateEdit.Text);

                    var lotNumber = lotNumberET.Text;

                    using (var db = new WereDesktopEntities())
                    {
                        Lot lot = new Lot();

                        lot.ID = id.ToString();
                        lot.ProductID = Lot.ProductID;
                        lot.Quantity = quantity;
                        lot.ExpirationDate = date;
                        lot.LotNumber = lotNumber;


                        db.Lot.AddOrUpdate(lot);

                        db.SaveChanges();
                        this.Close();
                    }

                }
            }
        }
        private void lotQuantityET_Validating(object sender, CancelEventArgs e)
        {
            ValidateLotQuantity();
        }
        private void lotDateEdit_Validating(object sender, CancelEventArgs e)
        {
            ValidateLotDate();
        }
        private void lotNumberET_Validating(object sender, CancelEventArgs e)
        {
            ValidateLotNumber();
        }
        private bool ValidateLotDate()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(lotDateEdit.Text))
            {
                dxErrorProvider.SetError(lotDateEdit, "Въвъдете дата за партидата!");
                dxErrorProvider.SetIconAlignment(lotDateEdit, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(lotDateEdit, null);
                dxErrorProvider.SetIconAlignment(lotDateEdit, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }
        private bool ValidateLotQuantity()
        {

            bool bStatus = true;
            if (lotQuantityET.Text == "")
            {
                dxErrorProvider.SetError(lotQuantityET, "Въведете количество на партидата!");
                dxErrorProvider.SetIconAlignment(lotQuantityET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(lotQuantityET, null);
                dxErrorProvider.SetIconAlignment(lotQuantityET, ErrorIconAlignment.MiddleRight);
                try
                {
                    double price = double.Parse(lotQuantityET.Text);
                    dxErrorProvider.SetError(lotQuantityET, null);
                    dxErrorProvider.SetIconAlignment(lotQuantityET, ErrorIconAlignment.MiddleRight);
                }
                catch
                {
                    dxErrorProvider.SetError(lotQuantityET, "Моля въведете число за количество на партидата!");
                    dxErrorProvider.SetIconAlignment(lotQuantityET, ErrorIconAlignment.MiddleRight);
                    bStatus = false;
                }
            }
            return bStatus;

        }
        private bool ValidateLotNumber()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(lotNumberET.Text))
            {
                dxErrorProvider.SetError(lotNumberET, "Въвъдете номер на партида!");
                dxErrorProvider.SetIconAlignment(lotNumberET, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider.SetError(lotNumberET, null);
                dxErrorProvider.SetIconAlignment(lotNumberET, ErrorIconAlignment.MiddleRight);

            }
            return bStatus;
        }
    }
}