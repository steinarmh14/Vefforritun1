using Project4.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project4.Controllers
{
    public class HomeController : ParentController
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            Random r1 = new Random();

            if(r1.Next() % 5 == 0)
            {
                throw new ArgumentException("Argument exception error appears");
            }

            if (r1.Next() % 5 == 1)
            {
                throw new MyApplicationException("My application error appears");
            }
         
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}