using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WereDesktop.Utils
{
    public class GenerateDocumentNumber
    {
        public static int generateDocumentNumber()
        {
            Random random = new Random();
            int abc = random.Next(1000);
            int value = 0;
            using (var db = new WereDesktopEntities())
            {
                value = db.Document.Count() + abc;
            }
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("ddMM");
            string inv = date + value;
            int docNumber = Int32.Parse(inv);
            return docNumber;
        }
    }
}
