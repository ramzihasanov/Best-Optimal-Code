using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    public class User
    {
        private static int _id;
        private string _password;
        private string _firstName;
        private string _lastName;
        public string Name
        {
            get => _firstName;
            set
            {
                bool check = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i])) check = false;
                }
                if (value != null && check) _firstName = value;
                else throw new InvalidNameException("ad yalnisdir");
            }
        }
        public int Id { get; }
        public string SurName
        {
            get => _lastName;
            set
            {
                bool check = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i])) check = false;
                }
                if (value != null && check) _lastName = value;
                else throw new InvalidNameException("soyad yalnisdir");
            }
        }
        public string UserName { get; }
        public string Password
        {
            get => _password;
            set
            {
                bool check = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i])) check = true;
                }
                if (value.Length > 7 && value[0] <= 'Z' && value[0] >= 'A' && check)
                    _password = value;
                else throw new InvalidPasswordException("pasword duzgun qeyd edilmeyib");
            }
        }

        static User()
        {
            _id = 0;
        }
        public User(string name, string surname, string password)
        {
            Name = name;
            SurName = surname;
            Password = password;
            _id++;
            Id = _id;
            UserName = Name.Trim() + "." + SurName.Trim();
        }
    }
}
