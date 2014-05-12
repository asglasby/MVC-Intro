using MVCIntro2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro2.Controllers
{
    public class HomeController : Controller
    {
        Dog myDog = new Dog()
        {
            Name = "Rex",
            Owner = "Me"
        };
        public ActionResult Index()
        {
            
            Dog myDog = new Dog();
            myDog.Owner = "Me";
            List<int> myList = new List<int>() {
            1,
            58,
            372
            };
            myList.Add(27);
            string noise = myDog.Speak();
            //return myList;
             return View(myList);
        }

        public ActionResult About()
        {
            
            List<Dog> myDogs = new List<Dog>();
            myDogs.Add(myDog);
            myDogs.Add(new Dog() { Name = "Spot", Owner = "Ed" });
            myDogs.Add(new Dog() { Legs = 10  });
            return View(myDogs);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dogs()
        {
            return View();
        }
    }
}