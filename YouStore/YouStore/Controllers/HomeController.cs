using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Models;
using YouStore.Models;

namespace YouStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Products()
        {
            return View();
        }
        public ActionResult Home()
        {
            AdminLogic adminlogic = new AdminLogic();
            List<Product> products = new List<Product>();

            //products.Add(new Product{ProductName="pp"});



            return View(adminlogic.GetAllProducts());
        }
        //test
        public IActionResult test()
        {
            return View();
        }
        public ActionResult HomeClient()
        {
            AdminLogic adminlogic = new AdminLogic();
            //List<Product> products = new List<Product>();

            //products.Add(new Product{ProductName="pp"});



            return View(adminlogic.GetAllProducts());
        }
    }
}
