using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private CategoryManager categoryManager;

        private void SaveCategoryClick(object sender, EventArgs e)
        {
            categoryManager = new CategoryManager();
            Category category = new Category();
            category.Name = nameTextBox.Text;
            if (categoryManager.IsExistCategory(category.Name)==true)
            {
                MessageBox.Show(category.Name + " Is Already Exist");
            }
            else
            {
                MessageBox.Show(categoryManager.SaveCategory(category.Name));
            }
            CategoryFormLoad();
        }

        private void CategoryFormLoad(object sender, EventArgs e)
        {
            CategoryFormLoad();
        }

        private void UpdateByDoubleClick(object sender, EventArgs e)
        {
            Category category = categoryItemListView.SelectedItems[0].Tag as Category;
            if (category != null)
            {
                hiddenLabel.Text = category.Id.ToString();
                nameTextBox.Text = category.Name;
            }
            //CategoryFormLoad();
        }

        private void UpdateCategoryClick(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = Convert.ToInt32(hiddenLabel.Text);
            category.Name = nameTextBox.Text;
            categoryManager = new CategoryManager();
            
            MessageBox.Show(categoryManager.UpdateCategory(category));
            categoryItemListView.Items.Clear();
            CategoryFormLoad();
            
        }

        public void CategoryFormLoad()
        {
            categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetAllCategories();
            categoryItemListView.Items.Clear();
            foreach (Category category in categories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToInt32(category.Id).ToString();
                item.SubItems.Add(category.Name);
                item.Tag = category;
                categoryItemListView.Items.Add(item);
            }
        }
    }
}
