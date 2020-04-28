using hello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hello.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> _person = new List<Person>()
            {
                new Person {Name = "ACH.KHAFID SALIM", Npm = "06.2017.1.06762" }
            };
            return View(_person);
        }
    }
}