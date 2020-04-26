using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Manager
{
    class ItemManager
    {
        ItemGateway itemGateway = new ItemGateway();
        private int rowEffected;
        private bool isExist;
        public string SaveItem(Item item)
        {
            rowEffected = itemGateway.SaveItem(item);
            if (rowEffected > 0)
            {
                return "Item Has Been Saved Successfully!";
            }
            return "There is An Error While Saving Item";
        }

        public bool IsExistItemName(string itemName)
        {
            isExist = itemGateway.IsExistItemName(itemName);
            return isExist;
        }
    }
}
