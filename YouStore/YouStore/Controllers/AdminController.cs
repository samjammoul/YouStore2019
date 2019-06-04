using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using YouStore.ViewsModels;
using System.Threading;
using Data;

namespace YouStore.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AdminHome()
        {
            return View();
        }
   

        public ActionResult ProductsList()
        {
            AdminLogic adminlogic = new AdminLogic();
            ResultDto<List<Product>> resultDto = adminlogic.GetAllProducts();
            if (resultDto.Success == false)
            {
                string errormessage = resultDto.Message;
                // laat error page zien
                return RedirectToAction("ProductsList", "Admin");
            }
            //products.Add(new Product{ProductName="pp"});


            return View(adminlogic.GetAllProducts());
        }
       



        public ActionResult AddProduct(AddProduct model)
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addProduct(AddProduct model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Product product = new Product();
            // product.ProductName = model.ProductName;
            //string productDescription = model.ProductDescription;
            //int productPrice = model.ProductPrijs;
            //int quantityInStock = model.QuantityInStock;
            //string image = model.Productimagelink;
            //string productCode = model.ProductCode;
            
          

            AdminLogic Adminlogic = new AdminLogic();
            Adminlogic.AddProduct(model.ProductName,model.ProductDescription,model.ProductPrijs,model.ProductCode, model.QuantityInStock, model.Productimagelink);
            

            return RedirectToAction("ProductsList", "Admin");
        }

        public ActionResult ShowOdersCount()
        {
            AdminLogic adminlogic = new AdminLogic();
          

            //products.Add(new Product{ProductName="pp"});



            return View(adminlogic.GetCountOfOrders());
        }

        
    }
}