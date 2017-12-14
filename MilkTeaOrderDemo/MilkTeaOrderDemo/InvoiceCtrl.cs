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
        private static string pathDetail = "..\\DetailReceiptData.txt";
        private static string path = "..\\ReceiptData.txt";

        List<InvoiceDetail> listInvoiceDetail, tempListInvoiceDetail;
        List<Invoice> listReceipt;
        FoodCtrl food_ctrl = new FoodCtrl();

        public InvoiceCtrl(FoodCtrl foodCtrl)
        {
            listInvoiceDetail = new List<InvoiceDetail>();
            tempListInvoiceDetail = new List<InvoiceDetail>();
            listReceipt = new List<Invoice>();
            food_ctrl = foodCtrl;
            if (listInvoiceDetail.Count == 0)
                InvoiceDetail.ID = 0;
            else InvoiceDetail.ID = listInvoiceDetail[listInvoiceDetail.Count - 1].idInvoice;
        }

        public void CreateReceiptDetailInfo(FoodModel food, int qtyProduct, DataGridView dgv)
        {
            int total = qtyProduct * food_ctrl.FindFood(food.IdFood).Price;
            InvoiceDetail tempreceiptdetail = new InvoiceDetail((food_ctrl.FindFood(food.IdFood)), qtyProduct);
            tempListInvoiceDetail.Add(tempreceiptdetail);
            dgv.DataSource = null;
            dgv.DataSource = tempListInvoiceDetail;
        }

        public void CreateReceiptInfo(int idMember, int idStaff)
        {
            int total_receipt = 0;
            for (int i = 0; i < tempListInvoiceDetail.Count; i++)
            {
                total_receipt += tempListInvoiceDetail[i].total;
            }
            Invoice receipt = new Invoice(tempListInvoiceDetail);
            listReceipt.Add(receipt);
            tempListInvoiceDetail = new List<InvoiceDetail>();
        }

        //public InvoiceDetail FindReceipt(int idreceipt)
        //{
        //    for (int i = 0; i < listInvoiceDetail.Count; i++)
        //    {
        //        if (listInvoiceDetail[i].idRecept == idreceipt)
        //            return listInvoiceDetail[i];
        //    }
        //    InvoiceDetail receipt = new InvoiceDetail();
        //    return receipt;
        //}

        //public void DeleteReceipt(int id)
        //{
        //    InvoiceDetail receipt = FindReceipt(id);
        //    listInvoiceDetail.Remove(receipt);
        //}

        //public void EditReceipt(int id, int idStaff, int idProduct, int qtyProduct)
        //{
        //    int index = listInvoiceDetail.IndexOf(FindReceipt(id));
        //    listInvoiceDetail[index].staff = staff_manage.FindStaff(idStaff);
        //    listInvoiceDetail[index].product = menu_manage.FindProduct(idProduct);
        //    listInvoiceDetail[index].total = qtyProduct * menu_manage.FindProduct(idProduct).sellValue;
        //}
    }
}
