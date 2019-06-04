using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public interface IAdminContext
    {
        void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink);
        ResultDto<List<Product>> GetAllProducts();

        ResultDto<List<Product>> GetCountOdOrders();
    }
}
