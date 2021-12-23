using System;
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
}
