using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Data.Context
{
    public class AdminContext : IAdminContext
    {
        public Product product;
        readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam\Desktop\S2\Indiviual\YouStore\YouStore\App_Data\Database1.mdf;Integrated Security=True";
        //Methode om data van  user colum uit de database te halen.
        public void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink)
        {
            //maak groep aan met ingelogde gebruiker als groepsadmin
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [Product] (ProductName, ProductDescription, ProductPrice, QuantityInStock, Image)" +
                                    "VALUES " +
                                    "('" + ProductName + "', '" + ProductDescription + "','" + ProductPrijs + "','" + QuantityInStock + "','" + Productimagelink + "')";
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
            catch (Exception ex)
            {
               
            }
        }
        //Get Products from DataBase
        public ResultDto<List<Product>> GetAllProducts()
        {
            List<Product> Productlist = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                     _conn.Open();
                    //string query = "SELECT * From [Product]";
                    using (SqlCommand cmd = new SqlCommand("GetAllProducts", _conn))
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                      //  cmd.CommandText = query;
                       
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
            catch (Exception ex)
            {
                return new ResultDto<List<Product>>()
                {
                    Data = null,
                    Success = false,
                    Message = ex.Message
                };
            }
            return new ResultDto<List<Product>>()
            {
                Data = Productlist,
                Success = true,
                Message = "Succesvol afgelopen"
            };
        }
        public ResultDto<List<Product>> GetCountOdOrders()
        {
            List<Product> ordedProducts = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT count(Product.ProductId)  as NumbrsofOrders ,Product.ProductId,product.ProductName FROM [Product] inner JOIN [Order] ON [Product].ProductId = [Order].ProductId Group By Product.ProductId,Product.ProductName;";
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
                                  
                                    int OrderedTimes = Convert.ToInt32(reader["NumbrsofOrders"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);


                                    Product Product = new Product(ProductName, OrderedTimes);

                                    ordedProducts.Add(Product);
                                }
                            }
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                return new ResultDto<List<Product>>()
                {
                    Data = null,
                    Success = false,
                    Message = ex.Message
                };
            }
            return new ResultDto<List<Product>>()
            {
                Data = ordedProducts,
                Success = true,
                Message = "Succesvol afgelopen"
            };
            
        }
    }
}
