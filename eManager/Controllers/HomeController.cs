using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Infraestructure;

namespace eManager.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _ds = new DeparmentDb();
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            var allDepartments=_ds.Deparments;
            ViewBag.test = "asd";
            return View(allDepartments);
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