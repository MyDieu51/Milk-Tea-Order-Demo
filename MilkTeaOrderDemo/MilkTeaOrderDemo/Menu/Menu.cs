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
    public partial class Menu : UserControl
    {
        public delegate void OrderEventHandler(object sender, EventArgs e, FoodModel food);
        public event OrderEventHandler PicDoubleClick;

        public Menu()
        {
            InitializeComponent();
        }

        FoodModel food = new FoodModel();

        public void LoadInfo(FoodModel input)
        {
            picFood.ImageLocation = input.PicLocal;
            lblName.Text = input.Name;
            lblPrice.Text = input.Price.ToString();
            food = input;
        }

        public FoodModel GetInfo()
        {
            return food;
        }

        private void picFood_MouseEnter(object sender, EventArgs e)
        {
            picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            picFood.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picFood_MouseLeave(object sender, EventArgs e)
        {
            picFood.SizeMode = PictureBoxSizeMode.Zoom;
            picFood.BorderStyle = BorderStyle.None;
        }

        private void picFood_Click(object sender, EventArgs e)
        {
            if (this.PicDoubleClick != null)
                this.PicDoubleClick(this, e, food);
        }
    }
}
