
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public static class UserService
    {

        public static void Register(string name, string surname, string password)
        {
            BlogDataBase.Users.ForEach(x => x.Name = name);
            BlogDataBase.Users.ForEach(x => x.SurName = surname);
            BlogDataBase.Users.ForEach(x => x.Password = password);
        }

        public static bool Login(string username, string password)
        {

            for (int i = 0; i < BlogDataBase.Users.Count; i++)
            {
                if (BlogDataBase.Users[i].UserName == username && BlogDataBase.Users[i].Password == password)
                    return true;

            }
            return false;
        }
    }
}
