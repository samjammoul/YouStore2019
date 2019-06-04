using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models;

namespace Data.Context
{
    public class YoutuberContext : IYoutuberContext
    {
        readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam\Desktop\S2\Indiviual\YouStore\YouStore\App_Data\Database1.mdf;Integrated Security=True";
        public List<Youtuber> GetAllYouTubers()
        {
            List<Youtuber> YoutubersList = new List<Youtuber>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT * From [Youtuber]";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int YoutberId = Convert.ToInt32(reader["YoutberId"]);
                                    string YoutuberName = Convert.ToString(reader["YoutuberName"]);
                                    string ImageLink = Convert.ToString(reader["ImageLink"]);

                                    Youtuber youtuber = new Youtuber(YoutberId, YoutuberName, ImageLink);

                                    YoutubersList.Add(youtuber);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //nothing here
            }
            return YoutubersList;
        }
        public List<Product> GetYoutubersProducts(int YoutuberId)
        {
            List<Product> Productlist = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT * FROM Product INNER JOIN Youtuber ON Product.YouTuberId = Youtuber.YoutberId where Product.YouTuberId = @YoutuberId; ";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.Add("@YoutuberId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@YoutuberId"].Value = YoutuberId;
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    //Hier de string variables werken wel maar de int  variables werken niet .Ik weet niet waarom maar ik ga aan mijn docenten vragen
                                    int ProductId = Convert.ToInt32(reader["ProductId"]);
                                    string ProductDescription = Convert.ToString(reader["ProductDescription"]);
                                    int ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                                    int QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
                                    string Image = Convert.ToString(reader["Image"]);
                                    string ProductCode = Convert.ToString(reader["ProductCode"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);


                                    Product Product = new Product(ProductName, ProductDescription, ProductPrice, QuantityInStock, Image, ProductCode, ProductId);

                                    Productlist.Add(Product);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //nothing here
            }
            return Productlist;
        }
    }
}
