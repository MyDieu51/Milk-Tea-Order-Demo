using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaOrderDemo
{
    public class FoodCtrl
    {
        private static string path = "..\\FoodData.txt";
        List<Food> listFoods;

        public List<Food> ListFoods
        {
            get { return listFoods; }
            set { listFoods = value; }
        }

        public FoodCtrl()
        {
            listFoods = new List<Food>();
            IOMethods.Instance.ReadData<Food>(path, ref listFoods);
            if (listFoods.Count != 0)
                Food.ID = listFoods[listFoods.Count - 1].IdFood;            
        }

        public void CreateFood(string name, int price, int basicPrice, string picLocal, DataGridView dgvMenu)
        {
            Food food = new Food(name, price, basicPrice, picLocal);
            listFoods.Add(food);
            IOMethods.Instance.WriteNewData<Food>(path, food);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listFoods;
        }

        public void LoadFoodInfo(int index, TextBox txtID, TextBox txtName, TextBox txtPrice, TextBox txtBasicPrice, PictureBox picBox)
        {
            txtID.Text = listFoods[index].IdFood.ToString();
            txtName.Text = listFoods[index].Name;
            txtPrice.Text = listFoods[index].Price.ToString();
            txtBasicPrice.Text = listFoods[index].BasicPrice.ToString();
            picBox.ImageLocation = listFoods[index].PicLocal;
        }

        public void EditFoodInfo(int index, string name, int price, int basicPrice, string picLocal, DataGridView dgvMenu)
        {
            listFoods[index].Name = name;
            listFoods[index].Price = price;
            listFoods[index].BasicPrice = basicPrice;
            listFoods[index].PicLocal = picLocal;
            IOMethods.Instance.EditData<Food>(path, listFoods);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listFoods;
        }

        public void DeleteFoodInfo(int index, DataGridView dgvMenu)
        {
            //File.Delete(listFoods[index].PicLocal);
            listFoods.RemoveAt(index);
            IOMethods.Instance.EditData<Food>(path, listFoods);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listFoods;
        }
    }
}
