using System;
namespace App_project
{
    public class CertainUser : ISignIN
    {
        int IDuser { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string SecondName { get; set; }

        public void Authorize(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
