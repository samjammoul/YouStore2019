using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models;

namespace Data.Context
{
    public class UserCollectionContext : IUserCollectionContext
    {
        public User user;
        readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam\Desktop\S2\Indiviual\YouStore\YouStore\App_Data\Database1.mdf;Integrated Security=True";
        // User user = new User(User.);
        public void SingUp(User user)
        {
            //maak groep aan met ingelogde gebruiker als groepsadmin
            try
            {

                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [User] (UserFirstName, UserLastName, City, Street, Province, Phone, PostalCode, Country, Email, Paswoord, Isadmin) " +
                                    "VALUES " +
                                    "('" + user.UserFirstName + "', '" + user.UserLastName + "','" + user.City + "','" + user.Street + "','" + user.State + "','" + user.Phone + "','" + user.PostalCode + "','" + user.Country + "','" + user.Email + "','" + user.Password + "','" + 0 + "')"; 
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;

                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception)
            {

            }

        }
    }
}
