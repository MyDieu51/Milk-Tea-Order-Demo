using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    class InvoiceCtrl
    {
        private static string path = "..\\ReceiptData.txt";

        List<InvoiceDetail> listInvoiceDetail;
        List<Invoice> listInvoice;
        FoodCtrl food_ctrl = new FoodCtrl();

        public InvoiceCtrl(FoodCtrl foodCtrl)
        {
            listInvoiceDetail = new List<InvoiceDetail>();            
            listInvoice = new List<Invoice>();
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
