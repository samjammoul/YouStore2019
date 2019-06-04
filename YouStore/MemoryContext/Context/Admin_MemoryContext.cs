using System;
using System.Collections.Generic;
using Models;

namespace MemoryContext.Context
{
    public class Admin_MemoryContext
    {
        public List<Product> GetAllProducts()
        {
           
         List<Product> Productlist = new List<Product>();
         Productlist.Add(new Product { ProductName = "Enzoknol phone cover", ProductDescription= "ProductDescription", ProductPrijs = 10,QuantityInStock=0,Productimagelink= "enzoPhoneCover.jpg"});







            //nothing here

            return Productlist;
        }
    }
}
