using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Manager
{
    class CompanyManager
    {
        CompanyGateway companyManager = new CompanyGateway();
        private int rowEffected;
        private bool isExist;

        public string SaveCompany(Company company)
        {
            rowEffected = companyManager.SaveCompany(company);
            if (rowEffected > 0)
            {
                return "Comapany Name Saved Successfully!";
            }
            return "There is An Error While Saving Company";
        }

        public bool IsExistCategory(string companyName)
        {
            isExist = companyManager.IsExistCategory(companyName);
            return isExist;
        }

        public List<Company> GetAllCompany()
        {
            return companyManager.GetAllCompany();
        }

    }
}
