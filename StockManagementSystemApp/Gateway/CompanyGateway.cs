using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Models;

namespace StockManagementSystemApp.Gateway
{
    class CompanyGateway
    {
        private string connString =
            @"Data Source=DESKTOP-UPLTLT5\SQL2012;Initial Catalog=StockManagementDB;Integrated Security=True";

        private string query;
        private int rowEffected;
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        private bool isExist = false;

        public int SaveCompany(Company company)
        {
            query = "INSERT INTO Companies VALUES('" + company.Name + "')";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            rowEffected = command.ExecuteNonQuery();
            connection.Close();
            return rowEffected;
        }

        public bool IsExistCategory(string companyName)
        {
            query = "SELECT Name FROM Companies WHERE Name='" + companyName + "'";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        public List<Company> GetAllCompany()
        {
            List<Company> companies = new List<Company>();
            query = "SELECT * FROM Companies ORDER BY Name ASC";
            connection = new SqlConnection(connString);
            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Company company = new Company();
                company.Id = Convert.ToInt32(reader["Id"].ToString());
                company.Name = reader["Name"].ToString();
                companies.Add(company);
            }
            reader.Close();
            connection.Close();
            return companies;
        }
    }
}
