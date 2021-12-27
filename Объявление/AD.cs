using System;
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
                        string localityOfMissing
                        //DateTime CheckDate,
                        //PetCard petCard)
                        )
        {
            SqlConnection connection = DataBase.LinkDataBase();

            //добавление в БД ADCard
            var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + IDPetCard_key.global_IDPetCard + "'", connection);
            var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

            SqlCommand cmd = new SqlCommand("INSERT INTO [PetDataBase].[dbo].[AdData] (IDPet, LocalityOfMissing) VALUES (@IDPet, @LocalityOfMissing)", connection);
            cmd.Parameters.AddWithValue("@IDPet", sqlForIdPet);
            cmd.Parameters.AddWithValue("@LocalityOfMissing", localityOfMissing);

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
