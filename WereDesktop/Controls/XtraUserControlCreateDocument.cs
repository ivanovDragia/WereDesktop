using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereDesktop.Classes;
using WereDesktop.Forms;
using WereDesktop.Utils;

namespace WereDesktop.Controls
{
    public partial class XtraUserControlCreateDocument : XtraUserControl
    {
        private AddProductToDocumentRowForm addProductToDocumentRowForm;
        private PayInCashForm payInCashForm;
        private MixedPaymentForm mixedPaymentForm;

        private SelectContragentForm selectContragentForm;
        public Product SelectedProduct => productGridView.GetFocusedRow() as Product;
        public DocumentRowCart SelectedRowTab1 => documentRowsTab1GridView.GetFocusedRow() as DocumentRowCart;
        public DocumentRowCart SelectedRowTab2 => documentRowsTab2GridView.GetFocusedRow() as DocumentRowCart;
        public DocumentRowCart SelectedRowTab3 => documentRowsTab3GridView.GetFocusedRow() as DocumentRowCart;
        public DocumentRowCart SelectedRowTab4 => documentRowsTab4GridView.GetFocusedRow() as DocumentRowCart;

        public List<Classes.DocumentRowCart> tab1DocumentRowsList = new List<Classes.DocumentRowCart>();
        public List<Classes.DocumentRowCart> tab2DocumentRowsList = new List<Classes.DocumentRowCart>();
        public List<Classes.DocumentRowCart> tab3DocumentRowsList = new List<Classes.DocumentRowCart>();
        public List<Classes.DocumentRowCart> tab4DocumentRowsList = new List<Classes.DocumentRowCart>();
        public XtraUserControlCreateDocument()
        {
            InitializeComponent();
            using (var db = new WereDesktopEntities())
            {
                //db.Lot.Load();
                productBindingSource.DataSource = db.Product.Include(p => p.Lot).ToList();
            }
            changeLabelValues();

        }
        private void payInCashButton_Click(object sender, EventArgs e)
        {
            //плащане кеш
            if (SelectedContragent.contragent != null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    if (tab1DocumentRowsList.Count > 0)
                    {
                        payInCashForm = new PayInCashForm(tab1DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        payInCashForm.MaximizeBox = false;
                        payInCashForm.MinimizeBox = false;
                        payInCashForm.ShowDialog();

                        tab1DocumentRowsList.Clear();
                        documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                        documentRowsTab1GridControl.RefreshDataSource();
                    }
                    
                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    if (tab2DocumentRowsList.Count > 0)
                    {
                        payInCashForm = new PayInCashForm(tab2DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        payInCashForm.MaximizeBox = false;
                        payInCashForm.MinimizeBox = false;
                        payInCashForm.ShowDialog();

                        tab2DocumentRowsList.Clear();
                        documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                        documentRowsTab2GridControl.RefreshDataSource();
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    if (tab3DocumentRowsList.Count > 0)
                    {
                        payInCashForm = new PayInCashForm(tab3DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        payInCashForm.MaximizeBox = false;
                        payInCashForm.MinimizeBox = false;
                        payInCashForm.ShowDialog();

                        tab3DocumentRowsList.Clear();
                        documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                        documentRowsTab3GridControl.RefreshDataSource();
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    if (tab4DocumentRowsList.Count > 0)
                    {
                        payInCashForm = new PayInCashForm(tab4DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        payInCashForm.MaximizeBox = false;
                        payInCashForm.MinimizeBox = false;
                        payInCashForm.ShowDialog();

                        tab4DocumentRowsList.Clear();
                        documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                        documentRowsTab4GridControl.RefreshDataSource();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Изберете контрагент!", "Грешка", MessageBoxButtons.OK);
            }

        }
        private void payWithCardButton_Click(object sender, EventArgs e)
        {
            //плащане с карта
            if (SelectedContragent.contragent != null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    if (tab1DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане с карта.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            //delete row from database or datagridview...
                            addDocumentToDatabaseWithCard(tab1DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab1DocumentRowsList.Clear();
                            documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                            documentRowsTab1GridControl.RefreshDataSource();
                        }
                    }
        
                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    if (tab2DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане с карта.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseWithCard(tab2DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab2DocumentRowsList.Clear();
                            documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                            documentRowsTab2GridControl.RefreshDataSource();
                        }
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    if (tab3DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане с карта.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseWithCard(tab3DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab3DocumentRowsList.Clear();
                            documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                            documentRowsTab3GridControl.RefreshDataSource();
                        }
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    if (tab4DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане с карта.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseWithCard(tab4DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab4DocumentRowsList.Clear();
                            documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                            documentRowsTab4GridControl.RefreshDataSource();
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Изберете контрагент!", "Грешка", MessageBoxButtons.OK);
            }

        }
        private void addDocumentToDatabaseWithCard(List<Classes.DocumentRowCart> list, decimal sum)
        {
            using (var db = new WereDesktopEntities())
            {
                Document document = new Document();
                Guid id = Guid.NewGuid();

                document.ID = id.ToString();
                document.SourceID = SelectedContragent.SourceContragentID;
                document.DestinationID = SelectedContragent.contragent.ID;
                document.DocumentNumber = GenerateDocumentNumber.generateDocumentNumber();
                document.Date = DateTime.Now;

                db.Document.AddOrUpdate(document);

                db.SaveChanges();

                foreach (DocumentRowCart dr in list)
                {
                    DocumentRow docRow = new DocumentRow();
                    docRow.ID = dr.ID;
                    docRow.ProductID = dr.ProductID;
                    docRow.LotID = dr.LotID;
                    docRow.Quantity = dr.Quantity;
                    docRow.Sum = dr.Sum;
                    docRow.DocumentID = document.ID;

                    db.DocumentRow.Add(docRow);

                    db.SaveChanges();
                }

                DocumentPayment dp = new DocumentPayment();
                id = Guid.NewGuid();

                dp.ID = id.ToString();
                dp.DocumentId = document.ID;
                dp.MethodOfPayment = "card";
                dp.Price = sum;

                db.DocumentPayment.Add(dp);

                db.SaveChanges();
            }
        }
        private void addDocumentToDatabaseToBankAccount(List<Classes.DocumentRowCart> list, decimal sum)
        {
            using (var db = new WereDesktopEntities())
            {
                Document document = new Document();
                Guid id = Guid.NewGuid();

                document.ID = id.ToString();
                document.SourceID = SelectedContragent.SourceContragentID;
                document.DestinationID = SelectedContragent.contragent.ID;
                document.DocumentNumber = GenerateDocumentNumber.generateDocumentNumber();
                document.Date = DateTime.Now;

                db.Document.AddOrUpdate(document);

                db.SaveChanges();

                foreach (DocumentRowCart dr in list)
                {
                    DocumentRow docRow = new DocumentRow();
                    docRow.ID = dr.ID;
                    docRow.ProductID = dr.ProductID;
                    docRow.LotID = dr.LotID;
                    docRow.Quantity = dr.Quantity;
                    docRow.Sum = dr.Sum;
                    docRow.DocumentID = document.ID;

                    db.DocumentRow.Add(docRow);

                    db.SaveChanges();
                }

                DocumentPayment dp = new DocumentPayment();
                id = Guid.NewGuid();

                dp.ID = id.ToString();
                dp.DocumentId = document.ID;
                dp.MethodOfPayment = "bank account";
                dp.Price = sum;

                db.DocumentPayment.Add(dp);

                db.SaveChanges();
            }
        }
        private void mixedPaymentButton_Click(object sender, EventArgs e)
        {
            //смесено плащане карта/кеш
            if (SelectedContragent.contragent != null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    if (tab1DocumentRowsList.Count > 0)
                    {
                        mixedPaymentForm = new MixedPaymentForm(tab1DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        mixedPaymentForm.MaximizeBox = false;
                        mixedPaymentForm.MinimizeBox = false;
                        mixedPaymentForm.ShowDialog();

                        tab1DocumentRowsList.Clear();
                        documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                        documentRowsTab1GridControl.RefreshDataSource();
                    }

                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    if (tab2DocumentRowsList.Count > 0)
                    {
                        mixedPaymentForm = new MixedPaymentForm(tab2DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        mixedPaymentForm.MaximizeBox = false;
                        mixedPaymentForm.MinimizeBox = false;
                        mixedPaymentForm.ShowDialog();

                        tab2DocumentRowsList.Clear();
                        documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                        documentRowsTab2GridControl.RefreshDataSource();
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    if (tab3DocumentRowsList.Count > 0)
                    {
                        mixedPaymentForm = new MixedPaymentForm(tab3DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        mixedPaymentForm.MaximizeBox = false;
                        mixedPaymentForm.MinimizeBox = false;
                        mixedPaymentForm.ShowDialog();

                        tab3DocumentRowsList.Clear();
                        documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                        documentRowsTab3GridControl.RefreshDataSource();
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    if (tab4DocumentRowsList.Count > 0)
                    {
                        mixedPaymentForm = new MixedPaymentForm(tab4DocumentRowsList, decimal.Parse(documentSumLabel.Text));
                        mixedPaymentForm.MaximizeBox = false;
                        mixedPaymentForm.MinimizeBox = false;
                        mixedPaymentForm.ShowDialog();

                        tab4DocumentRowsList.Clear();
                        documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                        documentRowsTab4GridControl.RefreshDataSource();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Изберете контрагент!", "Грешка", MessageBoxButtons.OK);
            }
        }
        private void payToBankAccountButton_Click(object sender, EventArgs e)
        {
            //плащане по сметка
            if (SelectedContragent.contragent != null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    if (tab1DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане по сметка.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            //delete row from database or datagridview...
                            addDocumentToDatabaseToBankAccount(tab1DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab1DocumentRowsList.Clear();
                            documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                            documentRowsTab1GridControl.RefreshDataSource();
                        }
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    if (tab2DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане по сметка.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseToBankAccount(tab2DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab2DocumentRowsList.Clear();
                            documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                            documentRowsTab2GridControl.RefreshDataSource();
                        }
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    if (tab3DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане по сметка.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseToBankAccount(tab3DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab3DocumentRowsList.Clear();
                            documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                            documentRowsTab3GridControl.RefreshDataSource();
                        }
                    }
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    if (tab4DocumentRowsList.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да направите плащане по сметка.", "Потвърждение", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            addDocumentToDatabaseToBankAccount(tab4DocumentRowsList, decimal.Parse(documentSumLabel.Text));

                            tab4DocumentRowsList.Clear();
                            documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                            documentRowsTab4GridControl.RefreshDataSource();
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Изберете контрагент!", "Грешка", MessageBoxButtons.OK);
            }
        }
        private void chooseContragentButton_Click(object sender, EventArgs e)
        {
            //избор на клиент
            selectContragentForm = new SelectContragentForm();
            selectContragentForm.MaximizeBox = false;
            selectContragentForm.MinimizeBox = false;
            selectContragentForm.ShowDialog();

            if (SelectedContragent.contragent != null)
            {
                Contragent contragent = SelectedContragent.contragent;
                contragentNameLabel.Text = contragent.Name;
            }

        }
        private void addProductToDocumentTab1Button_Click(object sender, EventArgs e)
        {
            //visible = false
        }
        private void editProductToDocumentTab1Button_Click(object sender, EventArgs e)
        {

        }
        private void deleteProductToDocumentTab1Button_Click(object sender, EventArgs e)
        {
            deleteRowTab1();
        }
        private void deleteProductToDocumentTab2Button_Click(object sender, EventArgs e)
        {
            deleteRowTab2();
        }
        private void deleteProductToDocumentTab3Button_Click(object sender, EventArgs e)
        {
            deleteRowTab3();
        }
        private void deleteProductToDocumentTab4Button_Click(object sender, EventArgs e)
        {
            deleteRowTab4();
        }
        private void deleteRowTab1()
        {
            var deleteRow = SelectedRowTab1;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избраната партида?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...


                if (deleteRow != null)
                {
                    var lotID = deleteRow.LotID;
                    using (var db = new WereDesktopEntities())
                    {

                        var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                        foreach (Lot lot in lots)
                        {
                            lot.Quantity = lot.Quantity + deleteRow.Quantity;
                            db.Lot.AddOrUpdate(lot);
                            db.SaveChanges();
                        }
                    }
                    tab1DocumentRowsList.Remove(deleteRow);

                    changeLabelValues();
                    documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                    documentRowsTab1GridControl.RefreshDataSource();
                }

            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }
        private void deleteRowTab2()
        {
            var deleteRow = SelectedRowTab2;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избраната партида?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...


                if (deleteRow != null)
                {
                    var lotID = deleteRow.LotID;
                    using (var db = new WereDesktopEntities())
                    {

                        var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                        foreach (Lot lot in lots)
                        {
                            lot.Quantity = lot.Quantity + deleteRow.Quantity;
                            db.Lot.AddOrUpdate(lot);
                            db.SaveChanges();
                        }
                    }
                    tab2DocumentRowsList.Remove(deleteRow);

                    changeLabelValues();
                    documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                    documentRowsTab2GridControl.RefreshDataSource();
                }

            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }
        private void deleteRowTab3()
        {
            var deleteRow = SelectedRowTab3;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избраната партида?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...


                if (deleteRow != null)
                {
                    var lotID = deleteRow.LotID;
                    using (var db = new WereDesktopEntities())
                    {

                        var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                        foreach (Lot lot in lots)
                        {
                            lot.Quantity = lot.Quantity + deleteRow.Quantity;
                            db.Lot.AddOrUpdate(lot);
                            db.SaveChanges();
                        }
                    }
                    tab3DocumentRowsList.Remove(deleteRow);

                    changeLabelValues();
                    documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                    documentRowsTab3GridControl.RefreshDataSource();
                }

            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }
        private void deleteRowTab4()
        {
            var deleteRow = SelectedRowTab1;
            DialogResult dr = MessageBox.Show("Сигурни ли сте, че искате да изтриете избраната партида?", "Потвърждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //delete row from database or datagridview...


                if (deleteRow != null)
                {
                    var lotID = deleteRow.LotID;
                    using (var db = new WereDesktopEntities())
                    {

                        var lots = db.Lot.Where(l => l.ID == lotID).ToList();
                        foreach (Lot lot in lots)
                        {
                            lot.Quantity = lot.Quantity + deleteRow.Quantity;
                            db.Lot.AddOrUpdate(lot);
                            db.SaveChanges();
                        }
                    }
                    tab4DocumentRowsList.Remove(deleteRow);

                    changeLabelValues();
                    documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                    documentRowsTab4GridControl.RefreshDataSource();
                }

            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }
        private void addProductToDocumentButton_Click(object sender, EventArgs e)
        {
            addProductToDocument();
        }
        private void addProductToDocument()
        {
            var selected = SelectedProduct;
            if (selected == null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab1DocumentRowsList);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                    documentRowsTab1GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab2DocumentRowsList);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                    documentRowsTab2GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab3DocumentRowsList);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                    documentRowsTab3GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab4DocumentRowsList);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                    documentRowsTab4GridControl.RefreshDataSource();
                }
            }
            else if (selected != null)
            {
                if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab1DocumentRowsList, selected);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource.DataSource = tab1DocumentRowsList;
                    documentRowsTab1GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab2DocumentRowsList, selected);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource1.DataSource = tab2DocumentRowsList;
                    documentRowsTab2GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab3DocumentRowsList, selected);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource2.DataSource = tab3DocumentRowsList;
                    documentRowsTab3GridControl.RefreshDataSource();
                }
                if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
                {
                    addProductToDocumentRowForm = new AddProductToDocumentRowForm(tab4DocumentRowsList, selected);
                    addProductToDocumentRowForm.MaximizeBox = false;
                    addProductToDocumentRowForm.MinimizeBox = false;
                    addProductToDocumentRowForm.ShowDialog();

                    documentRowCartBindingSource3.DataSource = tab4DocumentRowsList;
                    documentRowsTab4GridControl.RefreshDataSource();
                }
            }
            changeLabelValues();
        }
        private void documentsTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            changeLabelValues();
        }
        private void changeLabelValues()
        {
            if (documentsTabControl.SelectedTabPage.Equals(firstDocumentTabPage))
            {
                documentRowsCountLabel.Text = tab1DocumentRowsList.Count.ToString();
                double quantity = 0.0;
                decimal sum = 0;
                foreach (DocumentRowCart dr in tab1DocumentRowsList)
                {
                    quantity += dr.Quantity;
                    sum += dr.Sum;
                }
                documentRowsQuantityLabel.Text = quantity.ToString();
                documentSumLabel.Text = sum.ToString();

            }
            if (documentsTabControl.SelectedTabPage.Equals(secondDocumentTabPage))
            {
                documentRowsCountLabel.Text = tab2DocumentRowsList.Count.ToString();
                double quantity = 0.0;
                decimal sum = 0;
                foreach (DocumentRowCart dr in tab2DocumentRowsList)
                {
                    quantity += dr.Quantity;
                    sum += dr.Sum;
                }
                documentRowsQuantityLabel.Text = quantity.ToString();
                documentSumLabel.Text = sum.ToString();
            }
            if (documentsTabControl.SelectedTabPage.Equals(thirdDocumentTabPage))
            {
                documentRowsCountLabel.Text = tab3DocumentRowsList.Count.ToString();
                double quantity = 0.0;
                decimal sum = 0;
                foreach (DocumentRowCart dr in tab3DocumentRowsList)
                {
                    quantity += dr.Quantity;
                    sum += dr.Sum;
                }
                documentRowsQuantityLabel.Text = quantity.ToString();
                documentSumLabel.Text = sum.ToString();
            }
            if (documentsTabControl.SelectedTabPage.Equals(fourthDocumentTabPage))
            {
                documentRowsCountLabel.Text = tab4DocumentRowsList.Count.ToString();
                double quantity = 0.0;
                decimal sum = 0;
                foreach (DocumentRowCart dr in tab4DocumentRowsList)
                {
                    quantity += dr.Quantity;
                    sum += dr.Sum;
                }
                documentRowsQuantityLabel.Text = quantity.ToString();
                documentSumLabel.Text = sum.ToString();
            }
        }
        private void XtraUserControlCreateDocument_Load(object sender, EventArgs e)
        {
            //FixSplitterPosition(createDocumentSplitContainerControl);
        }
        private void productGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addProductToDocument();
        }
        private void documentRowsTab1GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteRowTab1();
            }
        }
        private void documentRowsTab2GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteRowTab2();
            }
        }
        private void documentsTabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteRowTab3();
            }
        }
        private void documentRowsTab4GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteRowTab4();
            }
        }
        private void documentRowsTab1GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void documentRowsTab2GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void documentRowsTab3GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void documentRowsTab4GridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}

