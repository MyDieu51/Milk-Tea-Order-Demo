using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public partial class OrderSide : UserControl
    {
        public OrderSide()
        {
            InitializeComponent();
        }

        private void OrderSide_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
