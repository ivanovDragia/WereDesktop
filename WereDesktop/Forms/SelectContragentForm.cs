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
using WereDesktop.Utils;

namespace WereDesktop.Forms
{
    public partial class SelectContragentForm : XtraForm
    {
        public SelectContragentForm()
        {
            InitializeComponent();
            using (var db = new WereDesktopEntities())
            {
                contragentTreeListLookUpEdit.Properties.DataSource = db.Contragent.ToList();
            }
        }

        private void selectContragentButton_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool bValidContragent = ValidateContragent();

            if (bValidContragent)
            {
                string contragentID = contragentTreeListLookUpEdit.EditValue.ToString();
                using (var db = new WereDesktopEntities())
                {
                    foreach (Contragent contragent in db.Contragent.Where(c => c.ID == contragentID).ToList())
                    {
                        SelectedContragent.contragent = contragent;
                    }
                }
                this.Close();
            }
        }

        private void contragentTreeListLookUpEdit_Validating(object sender, CancelEventArgs e)
        {
            ValidateContragent();
        }

        private bool ValidateContragent()
        {
            bool bStatus = true;
            if (contragentTreeListLookUpEdit.EditValue == null)
            {
                dxErrorProvider.SetError(contragentTreeListLookUpEdit, "Изберете контрагент!");
                dxErrorProvider.SetIconAlignment(contragentTreeListLookUpEdit, ErrorIconAlignment.MiddleRight);
                bStatus = false;
            }
            else
            {

                string contragentID = contragentTreeListLookUpEdit.EditValue.ToString();
                if (contragentID == null)
                {
                    dxErrorProvider.SetError(contragentTreeListLookUpEdit, "Изберете контрагент!");
                    dxErrorProvider.SetIconAlignment(contragentTreeListLookUpEdit, ErrorIconAlignment.MiddleRight);
                    bStatus = false;
                }
             
                dxErrorProvider.SetError(contragentTreeListLookUpEdit, null);
                dxErrorProvider.SetIconAlignment(contragentTreeListLookUpEdit, ErrorIconAlignment.MiddleRight);
            }
            return bStatus;
        }
    }
}
