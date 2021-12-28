﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static App_project.Controller;

namespace App_project
{

    //
    //Карточка ДЖ
    //
    public class PetCard
    {
        int IdCard { get; set; } //Id карточки дж
        string Category { get; set; } //категория животного
        public string Name { get; set; } //имя животного
        DateTime BirthDate { get; set; } //дата рождения животного
        string Breed { get; set; } //порода собаки
        DateTime RegistrationDate { get; set; } //дата регистрации
        int PassportNumber { get; set; } //номер паспорта
        CertainUser ThisPetOwner { get; set; } //Владелец собаки
        string Gender { get; set; } // пол животного
        Photo AnimalPhoto { get; set; } // фото животного
        string City { get; set; } // населенный пункт



        #region Конструкторы
        public PetCard()
        {

        }

        //?
        //конструктор
        public PetCard(string category,
                        string name,
                        DateTime birthDate,
                        string breed,
                        DateTime registrationDate,
                        int passportNumber,
                        CertainUser thisPetOwner,
                        string gender,
                        Photo animalPhoto,
                        string city
                        )
        {
            Category = category;
            Name = name;
            BirthDate = birthDate;
            Breed = breed;
            RegistrationDate = registrationDate;
            PassportNumber = passportNumber;
            ThisPetOwner = thisPetOwner;
            Gender = gender;
            AnimalPhoto = animalPhoto;
            City = city;
        }
        #endregion



        //Просмотр карточки ДЖ
        public void ShowPetCard(string idCard)
        {
            //throw new NotImplementedException();
            //Console.WriteLine("Карточка показана");

            // string SQLCheckLogin = "SELECT [Login] FROM [PetDataBase].[dbo].[LoginData] WHERE [Login] = '" + login + "'";

            SqlConnection connection = DataBase.LinkDataBase();

            string id_key = IDPetCard_key.global_IDPetCard;

            SqlCommand cmdCategory = new SqlCommand("SELECT [Category] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + id_key + "'", connection);

            SqlDataReader thisReaderCategory = cmdCategory.ExecuteReader();
            string res1 = string.Empty;
            while (thisReaderCategory.Read())
            {
                res1 += thisReaderCategory["Category"];
            }
            thisReaderCategory.Close();

            Category = res1;
        }




        //Добавление карточки ДЖ
        //public void AddNewPetCard(string category,
        //                string name,
        //                DateTime birthDate,
        //                string breed,
        //                DateTime registrationDate,
        //                int passportNumber,
        //                CertainUser thisPetOwner,
        //                string gender,
        //                Photo animalPhoto,
        //                string city)
        //{
        //    throw new NotImplementedException();
        //}

        //+
        public void AddNewPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber, //unique
                       string idUser,
                       string gender,
                       string locality,
                       string photo
            )
        {
            SqlConnection connection = DataBase.LinkDataBase();

            //SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality) VALUES (@Category, @NickName, @Breed, @PassportNumber, @IDUser, @Gender, @Locality)", connection);
            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality, Photo) VALUES (@Category, @NickName, @Breed, @PassportNumber, @IDUser, @Gender, @Locality, @Photo)", connection);

            //проверка на уникальность passportNumber
            string SQLCheckLogin = "SELECT [PassportNumber] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + passportNumber + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(SQLCheckLogin, DataBase.PetDBConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                byte[] images = null;
                FileStream stream = new FileStream(photo, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                if (table.Rows.Count == 0) 
                {

                    //добавление в БД в PetCard
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@NickName", nickName);
                    cmd.Parameters.AddWithValue("@Breed", breed);
                    cmd.Parameters.AddWithValue("@PassportNumber", passportNumber);
                    cmd.Parameters.AddWithValue("@IDUser", idUser);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Locality", locality);
                    cmd.Parameters.AddWithValue("@Photo", images);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так!");
                    }
                    finally
                    {
                        connection.Close();
                    }


                    //connection.Open();

                    ////добавление в БД в ADCard
                    //var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + passportNumber + "'", connection);
                    //var sqlForIdPet = PetDBSelectQuery.ExecuteScalar().ToString();

                    //SqlCommand cmd2 = new SqlCommand("INSERT INTO [PetDataBase].[dbo].[AdData] (IDPet, LocalityOfMissing) VALUES (@IDPet, @LocalityOfMissing)", connection);
                    //cmd2.Parameters.AddWithValue("@IDPet", sqlForIdPet);
                    //cmd2.Parameters.AddWithValue("@LocalityOfMissing", locality);

                    //try
                    //{
                    //    cmd2.ExecuteNonQuery();
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("Облом!");
                    //}
                    //finally
                    //{
                    //    connection.Close();
                    //}



                    MessageBox.Show("Карточка успешно добавлена!");

                }
                else
                {
                    MessageBox.Show("Не корректные данные проверьте правильность заполнения полей и уникальность номера паспорта");
                }
            }
        }




        //Редактирование карточки ДЖ

        //public void EditPetCard(PetCard petCard,
        //                string category,
        //                string name,
        //                DateTime birthDate,
        //                string breed,
        //                DateTime registrationDate,
        //                int passportNumber,
        //                CertainUser thisPetOwner,
        //                string gender,
        //                Photo animalPhoto,
        //                string city)
        //{
        //    throw new NotImplementedException();
        //}

        public void EditPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber, //unique
                       string idUser,
                       string gender,
                       string locality)
        {
          
        }





        //+-
        //Удаление карточки о пропаже домашнего животного

        //public void DeletePetCard(IdPetCard idCard)
        //{
        //    //throw new NotImplementedException();
        //    Console.WriteLine("Карточка удалена");
        //}

        public void DeletePetCard(string idCard)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            var PetDBSelectQuery = new SqlCommand("SELECT [IDPet] FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '" + idCard + "'", connection);
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



            string sql = string.Format("DELETE FROM [PetDataBase].[dbo].[PetData] WHERE [PassportNumber] = '{0}'", idCard);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Exception error = new Exception("Ошибка", ex);
                        throw error;
                    }
                }

        }












        //Сформировать паспорт домашнего животного в Microsoft Word
        public void Export2WordPetCard(IdPetCard idCard)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Паспорт сформирован");
        }

        //Экспорт карточки домашнего животного в Microsoft Excel
        public void Export2ExcelPetCard(IdPetCard idCard)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Карточка Экспортирована");
        }
    }
}
