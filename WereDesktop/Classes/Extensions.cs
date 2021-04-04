using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WereDesktop.Classes
{
    public static class Extensions
    {
        public static bool CheckTextValue(this BaseEdit baseEdit, DXErrorProvider errorProvider, string error)
        {
            if (string.IsNullOrEmpty(baseEdit.Text.Trim()))
            {
                errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                return false;
            }

            errorProvider.SetError(baseEdit, string.Empty, ErrorType.None);
            return true;
        }

        public static bool CheckDoubleValue(this BaseEdit baseEdit, DXErrorProvider errorProvider, string error)
        {
            if (string.IsNullOrEmpty(baseEdit.Text.Trim()))
            {
                errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                return false;
            }
            else if (double.Parse(baseEdit.Text.Trim())<=0)
            {
                errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                return false;
            }
            

            errorProvider.SetError(baseEdit, string.Empty, ErrorType.None);
            return true;
        }

        public static bool CheckLotValue(this BaseEdit baseEdit, double? maxQuantity, DXErrorProvider errorProvider, string error)
        {
            var text = baseEdit.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                return false;
            }
            else
            {
                if (double.TryParse(text, out double quantity))
                {
                    if (quantity > 0 && maxQuantity != null && quantity <= maxQuantity)
                    {
                        errorProvider.SetError(baseEdit, string.Empty, ErrorType.None);
                        return true;
                    }

                    errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                    return false;
                }

                errorProvider.SetError(baseEdit, error, ErrorType.Critical);
                return false;
            }

        }
    }
}
