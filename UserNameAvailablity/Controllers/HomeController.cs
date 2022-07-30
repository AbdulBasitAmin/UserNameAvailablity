using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserNameAvailablity.Models;

namespace UserNameAvailablity.Controllers
{
    public class HomeController : Controller
    {

        user_name_availablityEntities db = new user_name_availablityEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CheckUsernameAvailablity(string userdata)
        {
            System.Threading.Thread.Sleep(5500000);
            var SearchData = db.tbl_student.Where(x => x.StudName == userdata).SingleOrDefault();

            if (SearchData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);

            }
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