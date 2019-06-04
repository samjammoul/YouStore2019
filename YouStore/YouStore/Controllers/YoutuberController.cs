using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Logic;
using Models;

namespace YouStore.Controllers
{
    public class YoutuberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult YoutuberList()
        {
            YoutuberLogic yotuber = new YoutuberLogic();
            

            //products.Add(new Product{ProductName="pp"});



            return View(yotuber.GetAllYouTubers());
        }
        public IActionResult ShowYoutubers()
        {
            return RedirectToAction("YoutuberList", "Youtuber");
        }
        public ActionResult ShowYoutuberProducts(int? YoutuberId)
        {
            
            YoutuberLogic youtuberlogic = new YoutuberLogic();

           // ViewData["List"] = ClientLogic.GetAllProductsForUser(Convert.ToInt32(ClientId));
            //products.Add(new Product{ProductName="pp"});



            return View(youtuberlogic.GetYoutubersProducts(Convert.ToInt32(YoutuberId)));
        }
    }
}