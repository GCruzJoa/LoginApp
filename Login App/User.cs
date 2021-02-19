using System;
using System.Collections.Generic;
using System.Text;

namespace Login_App
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
        public User(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }

        public bool CheckInfoLogin()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return true;
                else return false;
        }
        public bool CheckInfoRegistro()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                return true;
            else return false;
        }
    }
}
