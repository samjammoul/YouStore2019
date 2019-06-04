using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Client : User
    {
        public Client(int id,string name, bool isAdmin, string email, string password)
        {

            UserFirstName = name;
            IsAdmin = isAdmin;
            Email = email;
            Password = password;
            Id = id; 
        }
        public Client()
        {
        }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public string UserFirstName { get; set; }
        //public bool IsAdmin { get; set; }







        //public Client(string userfirstname, string userlastname, string city, string street, string state, string phone, string postalcode, string country, string email, string password, string isadmin)
        //{
        //    UserFirstName = userfirstname;
        //    UserLastName = userlastname;
        //    City = city;
        //    Street = street;
        //    State = state;
        //    Phone = phone;
        //    PostalCode = postalcode;
        //    Country = country;
        //    Email = email;
        //    Password = password;
        //    IsAdmin = isadmin;


        //}
    }
}
