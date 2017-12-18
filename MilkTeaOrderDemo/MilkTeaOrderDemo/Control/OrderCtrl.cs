using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    class OrderCtrl
    {
        protected InvoiceCtrl invoiceCtrl;
        public FoodCtrl foodCtrl;
        Invoice tempInvoice;

        public OrderCtrl()
        {
            tempInvoice = new Invoice();
            invoiceCtrl = new InvoiceCtrl(foodCtrl);
        }

        public void Inil(FoodCtrl foodCtrl)
        {
            this.foodCtrl = foodCtrl;
        }

        public void InputOrder(Food food, DataGridView dgvListOrder, TextBox txtVAT, TextBox txtTotal)
        {
            InvoiceDetail tempreceiptdetail = new InvoiceDetail(food, 1);
            tempInvoice.listinvoiceDetail.Add(tempreceiptdetail);
            UpdateInvoice();
            UpdateOrder(dgvListOrder, txtVAT, txtTotal);
        }

        public void EditOrder(int index, int newQty, DataGridView dgvListOrder, TextBox txtVAT, TextBox txtTotal)//Fix
        {
            tempInvoice.listinvoiceDetail[index].qtyProduct = newQty;
            tempInvoice.listinvoiceDetail[index].total = tempInvoice.listinvoiceDetail[index].qtyProduct * tempInvoice.listinvoiceDetail[index].food.Price;
            UpdateInvoice();
            UpdateOrder(dgvListOrder, txtVAT, txtTotal);
        }

        public void DeleteOrder(int index, DataGridView dgv, TextBox txtVAT, TextBox txtTotal)
        {
            tempInvoice.listinvoiceDetail.RemoveAt(index);
            UpdateInvoice();
            UpdateOrder(dgv, txtVAT, txtTotal);
        }

        public void UpdateOrder(DataGridView dgv, TextBox txtVAT, TextBox txtTotal)
        {
            dgv.DataSource = null;
            dgv.DataSource = tempInvoice.listinvoiceDetail;
            txtVAT.Text = String.Format("{0:#,#}", tempInvoice.vat);
            txtTotal.Text = String.Format("{0:#,#}", tempInvoice.total);
        }

        public void UpdateInvoice()
        {
            int total = 0;
            foreach (InvoiceDetail item in tempInvoice.listinvoiceDetail)
            {
                total += item.total;
            }
            tempInvoice.vat = total * 0.1;
            tempInvoice.total = tempInvoice.vat + total;
        }

        public void Confirm()
        {
            invoiceCtrl.ConfirmPayment(tempInvoice);
        }
    }
}
