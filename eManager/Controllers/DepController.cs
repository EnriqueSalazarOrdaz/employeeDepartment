using eManager.Domain;
using eManager.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Controllers
{
    public class DepController : Controller
    {
        private IDepartmentDataSource _db;
        public DepController(IDepartmentDataSource db)
        {
            _db = db;
        }
        
        // GET: /Dep/
        public ActionResult Index()
        {

            return View(_db.Deparments);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            var rw = _db.Deparments.FirstOrDefault(x => x.id==id);
            return View();
        }
        [HttpGet]
        public ActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Detail(int id,string asd)
        {

            return View();
        }
        [HttpGet]
        public ActionResult Detail(int id)
        {
            var departDetail = _db.Deparments.Single(x=>x.id==id);
            return View(departDetail);
        }
    }
}