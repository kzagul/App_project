using System;
using System.Collections.Generic;

namespace App_project
{
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
}
