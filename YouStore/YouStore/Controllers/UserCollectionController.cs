using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Logic;
using Microsoft.AspNetCore.Http;

namespace YouStore.Controllers
{
    public class UserCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult SingUp(User model)
        {
            return View(model);
        }
        //public ActionResult SingUp()
        //{
        //    if (HttpContext.Session.GetInt32("role") == 1)
        //    {
        //        return View();
        //    }
        //    return RedirectToAction("Profile", "User");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult singUp(User model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //string name = HttpContext.Session.GetString("name");
            //string email = HttpContext.Session.GetString("email");
            //string password = HttpContext.Session.GetString("password");

            UserCollectionlogic userCollectionLogic = new UserCollectionlogic(model);
            userCollectionLogic.SignUp(model);
            userCollectionLogic.sendwelcommail(model.Email, model.UserFirstName);

            return RedirectToAction("Index", "Home");
        }
        

    }
}