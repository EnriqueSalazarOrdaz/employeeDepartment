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
	}
}