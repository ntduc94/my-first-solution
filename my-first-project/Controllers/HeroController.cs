using my_first_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace my_first_project.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            return View("Contact");
            //return View("~Views/Home/Index.cshtml");
        }

        public bool IsValid()
        {
            return false;
        }

        public ActionResult Contact()
        {
            return View();
        }

        public int HasPowerPoint()
        {
            return 100;
        }

        public RedirectToRouteResult ToHeroContact()
        {
            TempData["ToHeroContact"] = "To Hero Contact";
            return RedirectToAction("Contact", "Hero");
        }

        public RedirectResult ToGooglePage()
        {
            return Redirect("https://google.com");
        }

        public ActionResult Detail(int Id)
        {
            Hero SelectedHero;
            switch (Id)
            {
                case 1:
                    SelectedHero = new Hero("Superman", 100);
                    break;
                case 2:
                    SelectedHero = new Hero("Batman", 80);
                    break;
                default:
                    SelectedHero = new Hero("TienNg", 0);
                    break;
            }

            ViewData["FromTitle"] = "Hero Detail Form";
            ViewData["CurrentTime"] = DateTime.Now;
            ViewData["SelectedHero"] = SelectedHero;

            ViewBag.Hero = SelectedHero;

            return View();

            //return Newtonsoft.Json.JsonConvert.SerializeObject(SelectedHero);
        }
    }
}