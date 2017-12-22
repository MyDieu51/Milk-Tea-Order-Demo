using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    class InvoiceCtrl
    {
        private static string path = "..\\..\\data\\ReceiptData.txt";

        BindingList<InvoiceDetail> listInvoiceDetail;
        BindingList<Invoice> listInvoice;
        FoodCtrl food_ctrl = new FoodCtrl();

        public InvoiceCtrl(FoodCtrl foodCtrl)
        {
            listInvoiceDetail = new BindingList<InvoiceDetail>();            
            listInvoice = new BindingList<Invoice>();
            food_ctrl = foodCtrl;
            IOMethods.Instance.ReadData<Invoice>(path, ref listInvoice);
            if (listInvoice.Count != 0)
                Invoice.ID = listInvoice[listInvoice.Count - 1].idInvoice;
        }

        public void ConfirmPayment(Invoice invoice)
        {
            invoice.payment = true;
            IOMethods.Instance.WriteNewData<Invoice>(path, invoice);
            MessageBox.Show("Saved successfully!");
            invoice = new Invoice();
        }
    }
}
