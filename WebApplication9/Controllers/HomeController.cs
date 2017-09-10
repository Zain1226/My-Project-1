using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName, String Password)
        {
            if (UserName == "Ali" && Password == "pass123")
            {
                string msg = "Welcome" + UserName;
                return Content(msg);
            }
            else
            {
                return View();
            }
        }

    }
    
}