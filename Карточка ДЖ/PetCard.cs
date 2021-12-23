using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static App_project.Controller;

namespace App_project
{

    //
    //Карточка ДЖ
    //
    public class PetCard
    {
        IdPetCard IdCard { get; set; } //Id карточки дж
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

        public PetCard()
        {

        }

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

        //Просмотр карточки ДЖ
        public void ShowPetCard(IdPetCard idCard)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Карточка показана");
            
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

        public void AddNewPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber,
                       string idUser,
                       string gender,
                       string locality)
        {
            SqlConnection connection = DataBase.LinkDataBase();

            SqlCommand cmd = new SqlCommand("INSERT INTO[PetDataBase].[dbo].[PetData](Category, NickName, Breed, PassportNumber, IDUser, Gender, Locality) VALUES (@Category, @NickName, @Breed, @PassportNumber, @IDUser, @Gender, @Locality)", connection);

            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@NickName", nickName);
            cmd.Parameters.AddWithValue("@Breed", breed);
            cmd.Parameters.AddWithValue("@PassportNumber", passportNumber);
            cmd.Parameters.AddWithValue("@IDUser", idUser);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Locality", locality);
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
        }










        //Редактирование карточки ДЖ
        public void EditPetCard(PetCard petCard,
                        string category,
                        string name,
                        DateTime birthDate,
                        string breed,
                        DateTime registrationDate,
                        int passportNumber,
                        CertainUser thisPetOwner,
                        string gender,
                        Photo animalPhoto,
                        string city)
        {
            throw new NotImplementedException();
        }

        //Удаление карточки о пропаже домашнего животного
        public void DeletePetCard(IdPetCard idCard)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Карточка удалена");
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
