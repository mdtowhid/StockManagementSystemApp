using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Gateway
{
    class CategoryGateway
    {
        private string connString =
            @"Data Source=DESKTOP-UPLTLT5\SQL2012;Initial Catalog=StockManagementDB;Integrated Security=True";

        private string query;
        private int rowEffected;
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        private bool isExist = false;

        public int SaveCategory(string category)
        {
            query = "INSERT INTO Categories VALUES('" + category + "')";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            rowEffected = command.ExecuteNonQuery();
            connection.Close();
            return rowEffected;
        }

        public bool IsExistCategory(string categoryName)
        {
            query = "SELECT Name FROM Categories WHERE Name='"+categoryName+"'";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            isExist = reader.HasRows;
            reader.Close();
            connection.Close();

            return isExist;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            query = "SELECT * FROM Categories ORDER BY Name ASC";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Category aCategory = new Category();
                aCategory.Id = Convert.ToInt32(reader["Id"].ToString());
                aCategory.Name = reader["Name"].ToString();
                categories.Add(aCategory);
            }
            reader.Close();
            connection.Close();
            return categories;
        }

        public int UpdateCategory(Category category)
        {
            query = "UPDATE Categories SET Name='"+category.Name+"' WHERE Id = '"+category.Id+"'";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            rowEffected = command.ExecuteNonQuery();
            connection.Close();
            return rowEffected;
        }
    }
}
