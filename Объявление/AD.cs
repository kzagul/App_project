using System;
using System.Data;
using System.Data.SqlClient;
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
        public AD ShowAD(IdAD idAD)
        {
            throw new NotImplementedException();
        }

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



                //Редактирование объявления
        public void EditADCard(AD ad,
                        DateTime DateOfAd,
                        string LoosingPlace,
                        DateTime CheckDate,
                        PetCard petCard)
        {
            throw new NotImplementedException();
        }

        //Удаление объявления о пропаже домашнего животного
        public void DeleteADCard(AD ad)
        {
            throw new NotImplementedException();
        }
    }
}
