using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Traders_Pal1.Models;
using Traders_Pal1.Reporistry;

namespace Traders_Pal1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewRegistration(string am )
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            AccountModels routes_list = json_serializer.Deserialize<AccountModels>(am);                  
            AccountDB AB = new AccountDB();           
            var ac = AB.NewRegistration<ExicuteModel>(routes_list, 1);          
            return Json(new { status = ac.Flag, message = ac.Status, url = "" }, 0);
        }
        [HttpPost]
        public ActionResult Login(AccountModels lg)
        {
            
            AccountDB AB = new AccountDB();
            var ac = AB.Login<ExicuteModel>(lg);
            if (ac.Flag)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                return Json(new { status = ac.Flag, message ="Login faild"}, 0);
            }


           
        }
    }
}