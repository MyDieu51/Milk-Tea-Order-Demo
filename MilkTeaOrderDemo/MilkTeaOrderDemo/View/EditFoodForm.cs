using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MilkTeaOrderDemo
{
    public partial class EditFoodForm : UserControl
    {
        FoodCtrl foodCtrl;
        
        public EditFoodForm()
        {
            InitializeComponent();            
        }

        public void Inil(FoodCtrl foodCtrl)
        {
            this.foodCtrl = foodCtrl;
            LoadMenu();
        }

        public void LoadMenu()
        {
            txtID.Text = Food.ID.ToString();
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = foodCtrl.ListFoods;
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fulllocimage = openFileDialog1.FileName;
                pictureBox1.ImageLocation = fulllocimage;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrice.Text, out int price) && int.TryParse(txtBasicPrice.Text, out int basicPrice))
            {
                string newLocation = "";
                if (openFileDialog1.FileName != "openFileDialog1")
                {
                    string fulllocimage = openFileDialog1.FileName;
                    newLocation = Path.Combine("..\\..\\pic", Path.GetFileName(fulllocimage));
                    File.Copy(fulllocimage, newLocation, true);
                }
                foodCtrl.CreateFood(txtName.Text, price, basicPrice, newLocation, dgvMenu);
                ResetForm();
            }
            else MessageBox.Show("Please try again! Error: Wrong type of information");

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodCtrl.LoadFoodInfo(e.RowIndex, txtID, txtName, txtPrice, txtBasicPrice, pictureBox1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrice.Text, out int price) && int.TryParse(txtBasicPrice.Text, out int basicPrice))
            {
                string newLocation = "";
                if (openFileDialog1.FileName != "openFileDialog1" && openFileDialog1.FileName != "")
                {
                    string fulllocimage = openFileDialog1.FileName;
                    newLocation = Path.Combine("..\\..\\pic", Path.GetFileName(fulllocimage));
                    File.Copy(fulllocimage, newLocation, true);
                }
                else newLocation = pictureBox1.ImageLocation;
                foodCtrl.EditFoodInfo(int.Parse(txtID.Text), txtName.Text, price, basicPrice, newLocation, dgvMenu);
                ResetForm();
            }
            else MessageBox.Show("Please try again! Error: Wrong type of information");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                foodCtrl.DeleteFoodInfo(int.Parse(txtID.Text), dgvMenu);
                ResetForm();
            }                
            else return;            
        }

        private void ResetForm()
        {
            txtID.Text = Food.ID.ToString();
            txtName.Clear();
            txtPrice.Clear();
            txtBasicPrice.Clear();
            pictureBox1.ImageLocation = "";
            openFileDialog1.Reset();
        }
    }
}
