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
        public int idInvoice, total;
        public List<InvoiceDetail> listinvoiceDetail;
        public DateTime date;

        public Invoice(List<InvoiceDetail> listinvoiceDetail)
        {
            this.idInvoice = ID++;
            this.listinvoiceDetail = listinvoiceDetail;
            foreach (var item in listinvoiceDetail)
                total += item.total;
            this.date = DateTime.Now.Date;
        }
    }
}
