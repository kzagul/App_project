using System;
using System.Collections.Generic;

namespace App_project
{
    public class Controller
    {
        //
        #region объявление ДЖ
        //
        //объявление ДЖ
        //

        //Просмотр объявления
        public static List<string> ShowAD(
            //string categoryAnimal,
            //                    string nickName,
            //                    string locality,
            //                    string dateOfPosting,
            //                    string gender
            )
        {

            //new Journal().RegisterToJournal("ShowAd");

            //+
            return new AD().ShowAD(
                //categoryAnimal, nickName, locality, dateOfPosting, gender
                );
        
        }



            //Добавление объявления
        public static void AddNewAnnouncement(
                        string idPetCard,
                        string LoosingPlace,
                        string missingDate, 
                        string postDate)
        {
         //+
            new AD().AddNewAnnouncement(idPetCard, LoosingPlace, missingDate, postDate);

            new Journal().RegisterToJournal("AddNewAnnouncement");
        }

            //Редактирование объявления
        public static void EditADCard(string localityOfMissing, 
                                            string postDate, 
                                            string dateOfMissing)
        {
            //+
            new AD().EditADCard(localityOfMissing, postDate, dateOfMissing);

            //
            new Journal().RegisterToJournal("EditADCard");
        }

            //Удаление объявления о пропаже домашнего животного
        public static void DeleteADCard(string petCardID)
        {
            //+
            new AD().DeleteADCard(petCardID);

            //
            new Journal().RegisterToJournal("DeleteADCard");
        }

        /////////////////////////////////

        #endregion

        #region реестр объявлений
        /// 
        /// реестр объявлений
        /// 
        List<AD> adList;

            //Просмотр списка карточек ДЖ
            public static List<AD> LoadADList(IFilter filter, ISort sort)
            {
                throw new NotImplementedException();

            new Journal().RegisterToJournal(IDUser_key.global_IDUser);
        }

        /////////////////////////////////


        #endregion

        //
        #region Карточка ДЖ
        //
        //Карточка ДЖ
        //

        //Просмотр карточки ДЖ
        public static void ShowPetCard(string idCard)
        {
            //+
            new PetCard().ShowPetCard(idCard);

            //-
            new Journal().RegisterToJournal("ShowPetCard");
        }



        //Добавление карточки ДЖ
        public static void AddNewPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber,
                       string id,
                       string gender,
                       string city,
                       string photo,
                       string dateOfBirth,
                       string registrationDate
            )
        {
            //+
            new PetCard().AddNewPetCard(category, nickName, breed, passportNumber, id, gender, city, photo, dateOfBirth, registrationDate);
            
            //-
            new Journal().RegisterToJournal("AddNewPetCard");
        }





        //Редактирование карточки ДЖ
        public static void EditPetCard(string categoryAnimal, 
                                        string nickName, 
                                        string breed, 
                                        string passportNumber, 
                                        string idUser, 
                                        string dateOfBirth, 
                                        string registrationDate,
                                        string gender, 
                                        string locality)
            {
            //+
            new PetCard().EditPetCard(categoryAnimal, nickName, breed, passportNumber, idUser, dateOfBirth, registrationDate, gender, locality);

            //-
            new Journal().RegisterToJournal("EditPetCard");
        }



        //Удаление карточки о пропаже домашнего животного
        public static void DeletePetCard(string idCard)
        {
            //+
            new PetCard().DeletePetCard(idCard);

            //-
            new Journal().RegisterToJournal("DeletePetCard");
        }



            
            //Сформировать паспорт домашнего животного в Microsoft Word
        public static void Export2WordPetCard(string nickName, string categoryAnimal, string breed, string locality, string passportNumber, string dateofbirth, string dateofregistration, string fio, string gender)
        {
            //+
            new PetCard().Export2WordPetCard(nickName, categoryAnimal, breed, locality, passportNumber, dateofbirth, dateofregistration, fio, gender);

            //-
            new Journal().RegisterToJournal("Export2WordPetCard");
        }


  
            //Экспорт карточки домашнего животного в Microsoft Excel
        public static void Export2ExcelPetCard(string nickName, string categoryAnimal, string breed, string locality, string passportNumber, string dateofbirth,string dateofregistration,string fio, string gender)
        {
            //+
            new PetCard().Export2ExcelPetCard(nickName, categoryAnimal, breed, locality, passportNumber, dateofbirth, dateofregistration, fio, gender);

            //-
            new Journal().RegisterToJournal("Export2ExcelPetCard");
        }


        ///////////////////////////////////
        #endregion

        #region Реестр карточек домашних животных

        //
        //Реестр карточек домашних животных
        //

        List<PetCard> petList;

            //Просмотр списка карточек ДЖ
            public static List<PetCard> LoadPetList(IFilter filter, ISort sort)
            {
                throw new NotImplementedException();
            }

            //Экспорт записей реестра карточек домашних животных в Microsoft Excel
            public static void ExportPetRegisterExcel(List<PetCard> petList)
            {
                throw new NotImplementedException();
            }


        ///////////////////////////////////


        #endregion

        #region ВСПОМОГАТЕЛЬНЫЕ КЛАССЫ
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
            int id;
            public IdPetCard(int id)
            {
                this.id = id;
            }
        }


        //Класс для ID объявления
        public class IdAD
        {
            //
        }

        #endregion
    }
}
