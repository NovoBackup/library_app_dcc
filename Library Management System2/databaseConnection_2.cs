using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2
{
    class databaseConnection
    {
        public string GetConnectionString()
        {
            return @"server=DESKTOP-I9PHOTF\SQLEXPRESS;Integrated Security=SSPI;Database=Library_Management;";
        }
        public SqlConnection GetConnectionObj()
        {
            SqlConnection connectionObj = new SqlConnection(GetConnectionString());
            connectionObj.Open();
            return connectionObj;
        }
        public void ExecuteSqlCommandAndCloseConnection(string insertQueryString,SqlConnection connectionObj)
        {
            SqlCommand sqlCommandObj = new SqlCommand(insertQueryString, connectionObj);
            sqlCommandObj.ExecuteNonQuery();
            connectionObj.Close();
        }
    }
}
