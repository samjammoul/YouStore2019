using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using YouStorePro.ViewsModels;

namespace YouStore.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ClientLogic userLogic = new ClientLogic();
            foreach (var i in userLogic.GetAllUsers())
            {
                
                if (i.Email == model.Email && i.Password == model.Password)
                {
                    if (i.IsAdmin)
                    { return RedirectToAction("AdminHome", "Admin"); }
                    else
                    {
                        HttpContext.Session.SetString("Firstname", i.UserFirstName);
                        HttpContext.Session.SetString("Email", i.Email);
                        HttpContext.Session.SetInt32("ClientId", i.Id);
                        //HttpContext.Session.SetString("name", i.UserFirstName);
                        
                        
                        return RedirectToAction("HomeClient", "Home");
                    }
                    
                }
                
                
            }
            return View(model);
        }
        public ActionResult ProductenKopen()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            ClientLogic Clientlo = new ClientLogic();
            ShoppingBasketLogic  basket = new ShoppingBasketLogic();
            foreach (Product i in Clientlo.GetAllProductsForUser(Convert.ToInt32(ClientId)))
            {
                Clientlo.SetOrder(Convert.ToInt32(ClientId), i.ProductId);
            }

            return RedirectToAction("HomeClient", "Home");
        }
        public ActionResult OrdersList()
        {
            int? ClientId = HttpContext.Session.GetInt32("ClientId");
            ClientLogic clientlogic = new ClientLogic();
            

         



            return View(clientlogic.GetAllOrders(Convert.ToInt32(ClientId)));
        }





    }
}