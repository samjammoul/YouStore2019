 using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Data;
using Data.Context;
using Models;



namespace Logic
{
    public class AdminLogic : UserLogic
    {

        
        public string ProductName { get; set; }
        
        public string ProductDescription { get; set; }
      
        public int ProductPrijs { get; set; }
  
        public string ProductCode { get; set; }
 
        public int QuantityInStock { get; set; }
      
        public string Productimagelink { get; set; }
        Product product = new Product();

        private AdminRepository adminrepo = new AdminRepository(new AdminContext());

        public AdminLogic(Product product)
        {
            this.product = product;
       
        }
        public AdminLogic()
        {

        }

        public void AddProduct(string ProductName, string ProductDescription, int ProductPrijs, string ProductCode, int QuantityInStock, string Productimagelink)
        {
            
            adminrepo.AddProduct(ProductName, ProductDescription, ProductPrijs, ProductCode, QuantityInStock, Productimagelink);
        }

        public ResultDto<List<Product>> GetAllProducts()
        {
            return adminrepo.GetAllProducts();
        }

        public ResultDto<List<Product>> GetCountOfOrders() => adminrepo.GetCountOdOrders();
    }
  
}
