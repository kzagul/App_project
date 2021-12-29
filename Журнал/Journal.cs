using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_project
{
    class Journal
    {

        public void RegisterToJournal(string operation)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[Log] (DateAndTime, Operation, IDUser) VALUES (@DateAndTime, @Operation, @IDUser)", connection);

            cmd.Parameters.AddWithValue("@DateAndTime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@Operation", operation);
            cmd.Parameters.AddWithValue("@IDUser", IDUser_key.global_IDUser);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
               //
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
