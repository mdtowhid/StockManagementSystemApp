using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Manager
{
    class CategoryManager
    {
        private int rowEffected;
        private bool isExist;
        CategoryGateway categoryGateway = new CategoryGateway();

        public string SaveCategory(string category)
        {
            rowEffected = categoryGateway.SaveCategory(category);
            if (rowEffected > 0)
            {
                return "Category Saved Successfully!";
            }
            return "There is An Error While Saving Category";
        }

        public bool IsExistCategory(string categoryName)
        {
            isExist = categoryGateway.IsExistCategory(categoryName);
            return isExist;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = categoryGateway.GetAllCategories();
            return categories;
        }

        public string UpdateCategory(Category category)
        {
            rowEffected = categoryGateway.UpdateCategory(category);
            if (rowEffected > 0)
            {
                return "Category Name Is Updated Successfully!";
            }
            return "There is an Problem While Updating Data";
        }


    }
}
