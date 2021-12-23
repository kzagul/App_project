using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_project
{
    class DataBase
    {
        public static string PetDBConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=PetDataBase; Integrated Security=True";

        public static SqlConnection LinkDataBase()
        {
            SqlConnection connection = new SqlConnection(PetDBConnectionString);
            connection.Open();
            return connection;
        }
    }
}
