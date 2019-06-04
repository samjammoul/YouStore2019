using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;


namespace Data.Context
{
    public class ClientContext : IClientContext
    {
        readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam\Desktop\S2\Indiviual\YouStore\YouStore\App_Data\Database1.mdf;Integrated Security=True";


        public List<Client> GetAllUsers()
        {
            List<Client> clientList = new List<Client>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT * From [User]";
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
                                    int id = Convert.ToInt32(reader["Userid"]);
                                    string name = Convert.ToString(reader["UserFirstName"]);
                                    bool isAdmin = false;
                                    if (Convert.ToInt32(reader["Isadmin"]) == 1)
                                    {
                                        isAdmin = true;
                                    }
                                    string email = Convert.ToString(reader["Email"]);
                                    string password = Convert.ToString(reader["Paswoord"]);

                                    Client client = new Client(id, name, isAdmin, email, password);

                                    clientList.Add(client);
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
            return clientList;
        }
        //public void AddProductToShoppingBasket(string name, string email, int isadmin)
        //{
        //    //maak groep aan met ingelogde gebruiker als groepsadmin
        //    try
        //    {
        //        using (SqlConnection _conn = new SqlConnection(connectionString))
        //        {
        //            _conn.Open();
        //            string query = "INSERT INTO [USER] (name, email, admin) " +
        //                            "VALUES " +
        //                            "(@name, @email, @isadmin)";
        //            using (SqlCommand cmd = new SqlCommand(query, _conn))
        //            {
        //                cmd.CommandType = System.Data.CommandType.Text;

        //                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
        //                cmd.Parameters["@name"].Value = name;
        //                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
        //                cmd.Parameters["@email"].Value = email;
        //                cmd.Parameters.Add("@isadmin", System.Data.SqlDbType.Int);
        //                cmd.Parameters["@isadmin"].Value = isadmin;


        //                cmd.ExecuteNonQuery();
        //            }
        //            _conn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}
        public void AddProductToShoppingBasket(int ClienntId, int ProductId)
        {
            try
            {

                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [shoppingBasketNew] (ProductId, ClientId)" +
                                    "VALUES " +
                                    "(@ProductId,@ClienntId)";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.Add("@ProductId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductId"].Value = ProductId;
                        cmd.Parameters.Add("@ClienntId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClienntId"].Value = ClienntId;

                        cmd.ExecuteNonQuery();
                    }

                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

        }

        public List<Product> GetAllProductsForUser(int ClientId)
        {

            List<Product> BasketProducts = new List<Product>();


            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "select * from Product full Outer join shoppingBasketNew on Product.ProductId = shoppingBasketNew.ProductId where shoppingBasketNew.ClientId ='" + ClientId + "';";
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
                                
                                    string ProductDescription = Convert.ToString(reader["ProductDescription"]);
                                    int ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                                    // int QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
                                    string Image = Convert.ToString(reader["Image"]);
                                    // string ProductCode = Convert.ToString(reader["ProductCode"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);
                                    int ProductId = Convert.ToInt32(reader["ProductId"]);


                                    Product Product = new Product(ProductName, ProductDescription, ProductPrice, Image, ProductId);

                                    BasketProducts.Add(Product);
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
            return BasketProducts;

        }
        public void DeletProduct(int id, int Clientid)
        {
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "DELETE FROM [shoppingBasketNew] WHERE ClientId =@ClienntId AND ProductId= @id;";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.Add("@ClienntId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClienntId"].Value = Clientid;
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                        cmd.Parameters["@id"].Value = id;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void SetOrder(int ClientId , int ProductId)
        {

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [Order] (ProductId,UserId) VALUES(@ProductId,@ClientId); ";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ClientId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClientId"].Value = ClientId;

                        cmd.Parameters.Add("@ProductId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ProductId"].Value = ProductId;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                    
                }
            }
            catch (Exception)
            {
                //nothing here
            }

        }
        public List<Product> GetAllOrders(int ClientId)
        {
            List<Product> Orderslist = new List<Product>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    //StoredProcedure0
                    // string query = "SELECT * FROM [Product] INNER JOIN [Order] ON [Product].ProductId = [Order].ProductId  where UserId = @ClientId;";
                    using (SqlCommand cmd = new SqlCommand("GetAllOrders", _conn))
                    {
                        cmd.Parameters.Add("@ClientId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClientId"].Value = ClientId;

                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                       // cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                  
                                    int ProductId = Convert.ToInt32(reader["ProductId"]);
                                    string ProductDescription = Convert.ToString(reader["ProductDescription"]);
                                    int ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                                    int QuantityInStock = Convert.ToInt32(reader["QuantityInStock"]);
                                    string Image = Convert.ToString(reader["Image"]);
                                    string ProductCode = Convert.ToString(reader["ProductCode"]);
                                    string ProductName = Convert.ToString(reader["ProductName"]);


                                    Product Product = new Product(ProductName, ProductDescription, ProductPrice, QuantityInStock, Image, ProductCode, ProductId);

                                    Orderslist.Add(Product);
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
            return Orderslist;
        }

        // AddProductToShoppingBasket_addproduct_productadded() Unit Tests Helper
        public int GetShoppinBasketCount()
        {
            int ItemsCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(ProductId) as ItemsCount FROM[shoppingBasketNew]";
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
                                 
                                     ItemsCount = Convert.ToInt32(reader["ItemsCount"]);


                                
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
            return ItemsCount;

        }


        // SetOrder_AddOrder_Oderadded() Unit tests Helper
        //
        public int GetOrdersCount()
        {
            int OrdersCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(OrderId) as OrdersCount FROM[Order]";
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

                                    OrdersCount = Convert.ToInt32(reader["OrdersCount"]);



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
            return OrdersCount;

        }


        // SetOrder_AddOrder_ProductIsDeletedFromShoppingBasket() Unit tests Helper
        public int GetShoppinBasketCountById(int ClientId)
        {
            int ItemsCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(ProductId) as ItemsCount FROM[shoppingBasketNew] where ProductId = @ClientId;";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.Add("@ClientId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClientId"].Value = ClientId;

                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    ItemsCount = Convert.ToInt32(reader["ItemsCount"]);



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
            return ItemsCount;

        }


        public int GetProductsCount()
        {
            int ProductsCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(ProductId) as ProductsCount FROM [shoppingBasketNew]";
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

                                    ProductsCount = Convert.ToInt32(reader["ProductsCount"]);



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
            return ProductsCount;

        }

        public int GetUsersCount()
        {
            int UsersCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(Userid) as UserCount FROM[User];";
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

                                    UsersCount = Convert.ToInt32(reader["UserCount"]);



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
            return UsersCount;

        }

        public int GetProdctsCountOfUserInShoppingBasket(int ClientId)
        {
            int ProductsCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(ProductId) as ProductsCount FROM [shoppingBasketNew] where ClientId = @ClientId;";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.Add("@ClientId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClientId"].Value = ClientId;

                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    ProductsCount = Convert.ToInt32(reader["ProductsCount"]);



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
            return ProductsCount;

        }

        public int GetOrdersOfClient(int ClientId)
        {
            int OrdersCount = 0;
            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT COUNT(ProductId) as OrdersCount FROM [Order] where UserId = @ClientId;";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.Add("@ClientId", System.Data.SqlDbType.Int);
                        cmd.Parameters["@ClientId"].Value = ClientId;

                        cmd.Connection = _conn;
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = query;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    OrdersCount = Convert.ToInt32(reader["OrdersCount"]);



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
            return OrdersCount;

        }
        public List<ShoppingBasketItem> GetAllShoppingBasketItems()
        {
            List<ShoppingBasketItem> items = new List<ShoppingBasketItem>();

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "SELECT * From [shoppingBasketNew]";
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
                                    int ClientId = Convert.ToInt32(reader["Userid"]);
                                    int ProductId = Convert.ToInt32(reader["Userid"]);


                                    Client client = new Client(id, name, isAdmin, email, password);

                                    clientList.Add(client);
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
            return clientList;
        }

    }

}