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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private CompanyManager companyManager;
        private void SaveButtonClick(object sender, EventArgs e)
        {
            companyManager = new CompanyManager();
            Company company = new Company();
            company.Name = nameTextBox.Text;
            if (nameTextBox.Text == "")
            {
                MessageBox.Show(@"Please Provide Company Name");
            }
            else if (companyManager.IsExistCategory(company.Name))
            {
                MessageBox.Show(@"Company Name is Already Exist!");
            }
            else
            {
                MessageBox.Show(companyManager.SaveCompany(company));
            }
            nameTextBox.Clear();
        }

        private void CompanyDetailsFormLoad(object sender, EventArgs e)
        {
            companyManager = new CompanyManager();
            List<Company> companies = companyManager.GetAllCompany();
            foreach (Company company in companies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToInt32(company.Id).ToString();
                item.SubItems.Add(company.Name);
                item.Tag = company;
                companyListView.Items.Add(item);
            }

        }

        private void GetCompanyDataByDoubleClicking(object sender, EventArgs e)
        {
            Company company = companyListView.SelectedItems[0].Tag as Company;
            if (company != null) nameTextBox.Text = company.Name;
        }
    }
}
