using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaOrderDemo
{
    class Invoice
    {
        public static int ID;
        public int idInvoice;
        public double total, vat;
        public List<InvoiceDetail> listinvoiceDetail;
        public DateTime date;
        public DateTime time;
        public bool payment;

        public Invoice()
        {
            this.idInvoice = ID++;
            payment = false;
            date = DateTime.Now.Date;
            listinvoiceDetail = new List<InvoiceDetail>();
        }

        public Invoice(List<InvoiceDetail> listinvoiceDetail)
        {
            payment = false;
            this.idInvoice = ID++;
            this.listinvoiceDetail = listinvoiceDetail;
            foreach (var item in listinvoiceDetail)
                total += item.total;
            this.vat = total * 0.1;
            this.date = DateTime.Now.Date;
            this.time = DateTime.Now.ToLocalTime();
        }
    }
}
