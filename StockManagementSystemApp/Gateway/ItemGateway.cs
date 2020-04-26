using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Gateway
{
    class ItemGateway
    {
        private string connString =
            @"Data Source=DESKTOP-UPLTLT5\SQL2012;Initial Catalog=StockManagementDB;Integrated Security=True";

        private string query;
        private int rowEffected;
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        private bool isExist = false;

        public int SaveItem(Item item)
        {
            query = "INSERT INTO Items VALUES('" + item.CategoryId + "', '" + item.CompanyId + "', '" + item.Name + "', '" + item.ReorderLevel+"')";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            rowEffected = command.ExecuteNonQuery();
            connection.Close();
            return rowEffected;
        }

        public bool IsExistItemName(string itemName)
        {
            query = "SELECT ItemName FROM Items WHERE ItemName='" + itemName + "'";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }
    }
}
