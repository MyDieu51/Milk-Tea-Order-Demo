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
        List<Invoice> listReceipt;
        FoodCtrl food_ctrl = new FoodCtrl();

        public InvoiceCtrl(FoodCtrl foodCtrl)
        {
            listInvoiceDetail = new List<InvoiceDetail>();            
            listReceipt = new List<Invoice>();
            food_ctrl = foodCtrl;
            if (listInvoiceDetail.Count == 0)
                InvoiceDetail.ID = 0;
            else InvoiceDetail.ID = listInvoiceDetail[listInvoiceDetail.Count - 1].idInvoice;
        }

        public void ConfirmPayment(Invoice invoice)
        {
            invoice.payment = true;
            //Lenh ghi du lieu vao text
            MessageBox.Show("Đã lưu thành công!");
        }
    }
}
