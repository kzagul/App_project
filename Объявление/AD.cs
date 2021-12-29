using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static App_project.Controller;

namespace App_project
{
    public class AD
    {
        IdAD IdAd { get; set; } //Id объявления
        DateTime DateOfAd { get; set; } //дата добавления объявления
        string LoosingPlace { get; set; } // место пропажи
        DateTime CheckDate { get; set; } // дата пропажи/находки
        PetCard CardOfPet { get; set; } //карточка дж

        public AD()
        {

        }

        public AD(DateTime dateOfAd,
                  string loosingPlace,
                  DateTime checkDate,
                  PetCard cardOfPet)
        {
            DateOfAd = dateOfAd;
            LoosingPlace = loosingPlace;
            CheckDate = checkDate;
            CardOfPet = cardOfPet;
        }

        //Просмотр объявления
        public List<string> ShowAD(
            //string categoryAnimal,
            //                    string nickName,
            //                    string locality,
            //                    string dateOfPosting,
            //                    string gender
            )
        {
            string id_key = IDPetCard_key.global_PetCardPassport;


            var list = new List<string>();

            SqlConnection connection = DataBase.LinkDataBase();
                //Category
                SqlCommand cmdCategory = new SqlCommand("SELECT [Category] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderCategory = cmdCategory.ExecuteReader();
                string res1 = string.Empty;
                while (thisReaderCategory.Read())
                {
                    res1 += thisReaderCategory["Category"];
                }
                thisReaderCategory.Close();

            //categoryAnimal = res1;
            list.Add(res1);

                //NickName
                SqlCommand cmdNickName = new SqlCommand("SELECT [NickName] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderNickName = cmdNickName.ExecuteReader();
                string res3 = string.Empty;
                while (thisReaderNickName.Read())
                {
                    res3 += thisReaderNickName["NickName"];
                }
                thisReaderNickName.Close();
            //nickName = res3;
            list.Add(res3);


            //Locality
            SqlCommand cmdLocality = new SqlCommand("SELECT [Locality] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

                SqlDataReader thisReaderLocality = cmdLocality.ExecuteReader();
                string res4 = string.Empty;
                while (thisReaderLocality.Read())
                {
                    res4 += thisReaderLocality["Locality"];
                }
                thisReaderLocality.Close();
            //locality = res4;
            list.Add(res4);



            //DateOfPosting
            //DateOfPosting.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");

            SqlCommand cmdDateOfPost = new SqlCommand("SELECT [PostDate] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + IDPetCard_key.GetGlobalPetCardID() + "'", connection);

                SqlDataReader thisReaderDateOfPost = cmdDateOfPost.ExecuteReader();
                string res6 = string.Empty;
                while (thisReaderDateOfPost.Read())
                {
                    res6 += thisReaderDateOfPost["PostDate"];
                }
                thisReaderDateOfPost.Close();
            // dateOfPosting = res6;
            list.Add(res6);
            //Gender

            SqlCommand cmdGender = new SqlCommand("SELECT [Gender] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);
                var thisGender = cmdGender.ExecuteScalar().ToString();
                var res8 = "";
                if (thisGender == "male")
                {
                res8 = "Мужской";
                list.Add(res8);
                }
                else if (thisGender == "female")
                {
                res8 = "Женский";
                list.Add(res8);
                }

            return list;
        }

        //СДЕЛАНО
        //+
        //Добавление объявления
        public void AddNewAnnouncement(//DateTime DateOfAd,
                        string idPetCard,
                        string localityOfMissing,
                        string missingDate, 
                        string postDate
                        )
        {
            SqlConnection connection = DataBase.LinkDataBase();

            //добавление в БД ADCard
            var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + IDPetCard_key.global_PetCardPassport + "'", connection);
            var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO [PetDataBase].[dbo].[AdData] (IDPet, PostDate, LocalityOfMissing, DateOfMissing, IDUser) VALUES (@IDPet, @PostDate, @LocalityOfMissing, @DateOfMissing, @IDUser)", connection);

            //Проверка на уникальность IdPet
            string SQLCheckID = "SELECT [IDPet] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + idPetCard + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLCheckID, DataBase.PetDBConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 0)
                {

                    cmd.Parameters.AddWithValue("@IDPet", sqlForIdPet);
                    cmd.Parameters.AddWithValue("@PostDate", postDate);
                    cmd.Parameters.AddWithValue("@LocalityOfMissing", localityOfMissing);
                    cmd.Parameters.AddWithValue("@DateOfMissing", missingDate);
                    cmd.Parameters.AddWithValue("@IDUser", IDUser_key.global_IDUser);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }


                else
                {
                    MessageBox.Show("Не корректные данные проверьте правильность заполнения полей и уникальность номера паспорта");
                }
            }


        }


        //СДЕЛАНО
        //+
        //Редактирование объявления
        public void EditADCard(string localityOfMissing,
                                            string postDate,
                                            string dateOfMissing)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            string sql = string.Format("Update AdData Set PostDate = '{1}', LocalityOfMissing = '{2}', DateOfMissing = '{3}' Where IDPet = '{0}'",
            IDPetCard_key.GetGlobalPetCardID(), postDate, localityOfMissing, dateOfMissing);
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        //СДЕЛАНО
        //+
        //Удаление объявления о пропаже домашнего животного
        public void DeleteADCard(string petCardID)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '" + petCardID + "'", connection);
            var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

            string sql1 = string.Format("DELETE FROM [PetDataBase].[dbo].[AdData] WHERE [IDPet] = '{0}'", sqlForIdPet);
            using (SqlCommand cmd1 = new SqlCommand(sql1, connection))
            {
                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Ошибка", ex);
                    throw error;
                }
            }
        }
    }
}
