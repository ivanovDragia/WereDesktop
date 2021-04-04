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
    public partial class EditContragentForm : XtraForm
    {
        private Contragent contragent;

        public EditContragentForm(Contragent contragent)
        {
            InitializeComponent();
            this.contragent = contragent;
            editContragentNameTE.Text = contragent.Name;
            editContragentBulstatTE.Text = contragent.Bulstat;
            editContragentVatnumberTE.Text = contragent.VatNumber;
            editContragentCityTE.Text = contragent.City;
            editContragentAddressTE.Text = contragent.Address;
            editContragentMrpTE.Text = contragent.Mrp;
            editContragentPhoneTE.Text = contragent.PhoneNumber;
            CheckUserInput();

        }

        

        private void editContragentEditBtn_Click(object sender, EventArgs e)
        {
            var id = contragent.ID;

            var name = editContragentNameTE.Text;

            var bulstat = editContragentBulstatTE.Text;

            var vatNumber = editContragentVatnumberTE.Text;

            var city = editContragentCityTE.Text;

            var address = editContragentAddressTE.Text;

            var MRP = editContragentMrpTE.Text;

            var phoneNumber = editContragentPhoneTE.Text;

            using (var db = new WereDesktopEntities())
            {
                Contragent cont = new Contragent();


                cont.ID = id;
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

        private void CheckUserInput()
        {
            var isValid = true;

            

            isValid &= editContragentNameTE.CheckTextValue(dxErrorProvider, "Изберете име");
            isValid &= editContragentBulstatTE.CheckTextValue(dxErrorProvider, "Изберете булстат");
            isValid &= editContragentVatnumberTE.CheckTextValue(dxErrorProvider, "Изберете ват номер");
            isValid &= editContragentCityTE.CheckTextValue(dxErrorProvider, "Изберете град");
            isValid &= editContragentAddressTE.CheckTextValue(dxErrorProvider, "Изберете адрес");
            isValid &= editContragentMrpTE.CheckTextValue(dxErrorProvider, "Изберете мол");
            isValid &= editContragentPhoneTE.CheckTextValue(dxErrorProvider, "Изберете телефон");



            editContragentEditBtn.Enabled = isValid;
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            CheckUserInput();
        }
    }
}
