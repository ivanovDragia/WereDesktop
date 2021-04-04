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
    public partial class AddContragentForm : XtraForm
    {
        public AddContragentForm()
        {
            InitializeComponent();
        }

        private void addContragentBtn_Click(object sender, EventArgs e)
        {

            ValidateForm();
        }

        private void ValidateForm()
        {
            bool cValidName = ValidateContragentName();
            bool cValidBulstat = ValidateContragentBulstat();
            bool cValidVatNumber = ValidateContragentVatNumber();
            bool cValidCity = ValidateContragentCity();
            bool cValidAdresss = ValidateContragentAddress();
            bool cValidateMrp = ValidateContragentMrp();
            bool cValidatePhone = ValidateContragentPhoneNumber();

            if (cValidName && cValidBulstat && cValidVatNumber && cValidCity
                && cValidAdresss && cValidateMrp && cValidatePhone) 
            {
                var name = addContragentNameTE.Text;

                var bulstat = addContragentBulstatTE.Text;

                var vatNumber = addContragentVatNumberTE.Text;

                var city = addContragentCityTE.Text;

                var address = addContragentAddressTE.Text;

                var MRP = addContragentMrpTE.Text;

                var phoneNumber = addContragentPhoneNumberTE.Text;

                using (var db = new WereDesktopEntities())
                {
                    Contragent cont = new Contragent();
                    Guid id = Guid.NewGuid();

                    cont.ID = id.ToString();
                    cont.Name = name;
                    cont.Bulstat = bulstat;
                    cont.VatNumber = vatNumber;
                    cont.City = city;
                    cont.Address = address;
                    cont.Mrp = MRP;
                    cont.PhoneNumber = phoneNumber;


                    db.Contragent.AddOrUpdate(cont);

                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void addContragentNameTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentName();
        }

        private bool ValidateContragentName()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentNameTE.Text))
            {
                dxErrorProvider1.SetError(addContragentNameTE, "Въвъдете име на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentNameTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentNameTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentNameTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentBulstatTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentBulstat();
        }

        private bool ValidateContragentBulstat()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentBulstatTE.Text))
            {
                dxErrorProvider1.SetError(addContragentBulstatTE, "Въвъдете булстат на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentBulstatTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentBulstatTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentBulstatTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentVatNumberTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentVatNumber();
        }

        private bool ValidateContragentVatNumber()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentVatNumberTE.Text))
            {
                dxErrorProvider1.SetError(addContragentVatNumberTE, "Въвъдете ват номер на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentVatNumberTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentVatNumberTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentVatNumberTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentCityTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentCity();
        }

        private bool ValidateContragentCity()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentCityTE.Text))
            {
                dxErrorProvider1.SetError(addContragentCityTE, "Въвъдете град на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentCityTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentCityTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentCityTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentAddressTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentAddress();
        }

        private bool ValidateContragentAddress()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentAddressTE.Text))
            {
                dxErrorProvider1.SetError(addContragentAddressTE, "Въвъдете адрес на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentAddressTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentAddressTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentAddressTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentMrpTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentMrp();
        }

        private bool ValidateContragentMrp()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentMrpTE.Text))
            {
                dxErrorProvider1.SetError(addContragentMrpTE, "Въвъдете мол на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentMrpTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentMrpTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentMrpTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }

        private void addContragentPhoneNumberTE_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragentPhoneNumber();
        }

        private bool ValidateContragentPhoneNumber()
        {
            bool bStatus = true;
            if (String.IsNullOrEmpty(addContragentPhoneNumberTE.Text))
            {
                dxErrorProvider1.SetError(addContragentPhoneNumberTE, "Въвъдете телефон на контрагента!");
                dxErrorProvider1.SetIconAlignment(addContragentPhoneNumberTE, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(addContragentPhoneNumberTE, null);
                dxErrorProvider1.SetIconAlignment(addContragentPhoneNumberTE, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }
    }
}
