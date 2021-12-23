using System;
using System.Collections.Generic;

namespace App_project
{
    public class Controller
    {
        #region объявление ДЖ
        //
        //объявление ДЖ
        //

        //Просмотр объявления
        public static AD ShowAD(IdAD idAD)
            {
                throw new NotImplementedException();
            }

            //Добавление объявления
            public static void AddNewAnnouncement(DateTime DateOfAd,
                            string LoosingPlace,
                            DateTime CheckDate,
                            PetCard petCard)
            {
                throw new NotImplementedException();
            }

            //Редактирование объявления
            public static void EditADCard(IdAD idAD,
                            DateTime DateOfAd,
                            string LoosingPlace,
                            DateTime CheckDate,
                            PetCard petCard)
            {
                //
            }

            //Удаление объявления о пропаже домашнего животного
            public static void DeleteADCard(IdAD idAD)
            {
                throw new NotImplementedException();
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
            }

        /////////////////////////////////


        #endregion

        #region Карточка ДЖ
        //
        //Карточка ДЖ
        //

        //Просмотр карточки ДЖ
        public static void ShowPetCard(IdPetCard idCard)
            {
                new PetCard().ShowPetCard(idCard);
            }

        //Добавление карточки ДЖ
        //public static void AddNewPetCard(string category,
        //                    string name,
        //                    DateTime birthDate,
        //                    string breed,
        //                    DateTime registrationDate,
        //                    int passportNumber,
        //                    CertainUser thisPetOwner,
        //                    string gender,
        //                    Photo animalPhoto,
        //                    string city)
        //    {
        //        throw new NotImplementedException();
        //    }

        public static void AddNewPetCard(string category,
                       string nickName,
                       string breed,
                       int passportNumber,
                       string id,
                       string gender,
                       string city)
        {
            new PetCard().AddNewPetCard(category, nickName, breed, passportNumber, id, gender, city);
        }





        //Редактирование карточки ДЖ
        public static void EditPetCard(PetCard petCard,
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
        public static void DeletePetCard(IdPetCard idCard)
        {
            new PetCard().DeletePetCard(idCard);
        }

            //Сформировать паспорт домашнего животного в Microsoft Word
        public static void Export2WordPetCard(IdPetCard idCard)
        {
            new PetCard().Export2WordPetCard(idCard);
        }

            //Экспорт карточки домашнего животного в Microsoft Excel
        public static void Export2ExcelPetCard(IdPetCard idCard)
        {
            new PetCard().Export2ExcelPetCard(idCard);
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
