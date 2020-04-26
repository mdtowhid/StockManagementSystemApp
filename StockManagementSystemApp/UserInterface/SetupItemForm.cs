using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.UserInterface
{
    public partial class SetupItemForm : Form
    {
        public SetupItemForm()
        {
            InitializeComponent();
        }

        CategoryManager categoryManager = new CategoryManager();
        CompanyManager companyManager = new CompanyManager();
        ItemManager itemManager = new ItemManager();
        private void SaveItemButtonClick(object sender, EventArgs e)
        {
            if (categoryComboBox.Text == @"--Select Category--")
            {
                MessageBox.Show(@"Please Select Category Name", @"Combox1", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            else if (companyComboBox.Text == @"--Select Company--")
            {
                MessageBox.Show(@"Please Select Company Name");
            }
            else if (itemNameTextBox.Text == "")
            {
                MessageBox.Show(@"Please Provide Item Name");
            }
            else if (reorderLevelTextBox.Text == "")
            {
                MessageBox.Show(@"Please Provide Re-order Lavel");
            }
            else
            {
                Item item = new Item();
                item.CategoryId = categoryComboBox.SelectedIndex;
                item.CompanyId = companyComboBox.SelectedIndex;
                item.Name = itemNameTextBox.Text;
                if (itemManager.IsExistItemName(item.Name))
                {
                    MessageBox.Show(@"This Item Name Already Exist!", @"Already Exist", MessageBoxButtons.OKCancel);
                    itemNameTextBox.Clear();
                }
                else
                {
                    item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                    MessageBox.Show(itemManager.SaveItem(item), @"Save Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void SetupItemForm_Load(object sender, EventArgs e)
        {
            Category defaultCategory = new Category();
            defaultCategory.Id = -1;
            defaultCategory.Name = "--Select Category--";

            List<Category> categories = new List<Category>();

            categories.Add(defaultCategory);
            categories.AddRange(categoryManager.GetAllCategories());

            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DataSource = categories;

            List<Company> companies = new List<Company>();
            Company defaultCompany = new Company();
            defaultCompany.Id = -1;
            defaultCompany.Name = "--Select Company--";
            companies.Add(defaultCompany);
            companies.AddRange(companyManager.GetAllCompany());
            companyComboBox.DisplayMember = "Name";
            companyComboBox.ValueMember = "Id";
            companyComboBox.DataSource = companies;
        }

        private void ResetButtomClick(object sender, EventArgs e)
        {
            categoryComboBox.SelectedItem = null;
            categoryComboBox.SelectedIndex = 0;
            companyComboBox.SelectedItem = null;
            companyComboBox.SelectedIndex = 0;
            itemNameTextBox.Clear();
            reorderLevelTextBox.Text = Convert.ToInt32(0).ToString();
        }
    }
}
