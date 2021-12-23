using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_project
{
    class User
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
}
