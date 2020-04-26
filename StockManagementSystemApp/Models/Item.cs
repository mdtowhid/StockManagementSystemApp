using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Models
{
    class Item
    {
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public Item()
        {
            Categories = new List<Category>();
            Companies = new List<Company>();
        }
        public List<Category> Categories { get; set; }
        public List<Company> Companies { get; set; }
        public string Name { get; set; }
        public int ReorderLevel { get; set; }

    }
}
