using System;
using System.Collections.Generic;

namespace _7lab
{
    class System
    {
        /// 
        /// Интерфейс для фильтра
        /// 
        public interface IFilter
        {
             void ToFilter();
        }

        /// 
        /// Интерфейс для сортировки
        /// 
        public interface ISort
        {
             void ToSort();
        }


        //
        //объявление ДЖ
        //
        public class AD
        {
            IdAD IdAd { get; set; } //Id объявления
            DateTime DateOfAd { get; set; } //дата добавления объявления
            string LoosingPlace { get; set; } // место пропажи
            DateTime CheckDate { get; set; } // дата пропажи/находки
            PetCard CardOfPet { get; set; } //карточка дж

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
            public void AddNewAnnouncement(DateTime DateOfAd,
                            string LoosingPlace,
                            DateTime CheckDate,
                            PetCard petCard)
            {
                throw new NotImplementedException();
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

        /// 
        /// реестр объявлений
        /// 
        public class ADList
        {
            List<AD> adList;

            //конструктор
            public ADList()
            {
            }

            //Просмотр списка карточек ДЖ
            public List<AD> LoadADList(IFilter filter, ISort sort)
            {
                throw new NotImplementedException();
            }
        }

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
            User ThisPetOwner { get; set; } //Владелец собаки
            string Gender { get; set; } // пол животного
            Photo AnimalPhoto { get; set; } // фото животного
            string City { get; set; } // населенный пункт

            //конструктор
            public PetCard(string category,
                            string name,
                            DateTime birthDate,
                            string breed,
                            DateTime registrationDate,
                            int passportNumber,
                            User thisPetOwner,
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
            public PetCard ShowPetCard(IdPetCard idCard)
            {
                throw new NotImplementedException();
            }

            //Добавление карточки ДЖ
            public void AddNewPetCard(string category,
                            string name,
                            DateTime birthDate,
                            string breed,
                            DateTime registrationDate,
                            int passportNumber,
                            User thisPetOwner,
                            string gender,
                            Photo animalPhoto,
                            string city)
            {
                throw new NotImplementedException();
            }

            //Редактирование карточки ДЖ
            public void EditPetCard(PetCard petCard,
                            string category,
                            string name,
                            DateTime birthDate,
                            string breed,
                            DateTime registrationDate,
                            int passportNumber,
                            User thisPetOwner,
                            string gender,
                            Photo animalPhoto,
                            string city)
            {
                throw new NotImplementedException();
            }

            //Удаление карточки о пропаже домашнего животного
            public void DeletePetCard(PetCard petCard)
            {
                throw new NotImplementedException();
            }

            //Сформировать паспорт домашнего животного в Microsoft Word
            public void Export2WordPetCard(PetCard petCard)
            {
                throw new NotImplementedException();
            }

            //Экспорт карточки домашнего животного в Microsoft Excel
            public void Export2ExcelPetCard(PetCard petCard)
            {
                throw new NotImplementedException();
            }
        }


        //
        //Реестр карточек домашних животных
        //
        public class ListPetCards
        {
            List<PetCard> petList;

            public ListPetCards()
            {
                //Конструктор
            }

            //Просмотр списка карточек ДЖ
            public List<PetCard> LoadPetList(IFilter filter, ISort sort)
            {
                throw new NotImplementedException();
            }

            //Экспорт записей реестра карточек домашних животных в Microsoft Excel
            public void ExportPetRegisterExcel(List<PetCard> petList)
            {
                throw new NotImplementedException();
            }
        }


        //
        //Интефейс Авторизации
        //
        public interface ISignIN
        {
             void ToAuthorize(string login, string password);
        }


        public class Admin : ISignIN
        {
            public void ToAuthorize(string login, string password)
            {
                throw new NotImplementedException();
            }
        }


        //КЛАСС Пользователя
        public class User : ISignIN
        {
            int IDuser { get; set; }
            string Name { get; set; }
            string Surname { get; set; }
            string SecondName { get; set; }

            public void ToAuthorize(string login, string password)
            {
                throw new NotImplementedException();
            }
        }


        //
        //Интефейс Регистрации
        //
        public interface ISignUP
        {
             void toRegistrate(string login, string password);
        }


        //ВСПОМОГАТЕЛЬНЫЕ КЛАССЫ

        //класс фотографии
        public class Photo
        {
            public Photo()
            {
                //kind of magic
            }
        }

        //Класс для ID карточки ДЖ
        public class IdPetCard
        {
            //
        }

        //Класс для ID объявления
        public class IdAD
        {
            //
        }
    }
}
