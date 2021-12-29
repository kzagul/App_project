using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_project
{
    class IDPetCard_key
    {
        public static string global_PetCardPassport;

        public static void GetIDPetCardForSession(string login)
        {
            //создание подключения
            var connection = DataBase.LinkDataBase();
            var SelectID = new SqlCommand("SELECT [IDUser] FROM [PetDataBase].[dbo].[LoginData] WHERE [Login] = '" + login + "'", connection);
            IDUser_key.global_IDUser = SelectID.ExecuteScalar().ToString();
        }

        public static string GetGlobalPetCardID()
        {
            var connection = DataBase.LinkDataBase();
            var sql = new SqlCommand("Select IDPet from [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + IDPetCard_key.global_PetCardPassport + "'", connection);
            return sql.ExecuteScalar().ToString();
        }

    }
}
