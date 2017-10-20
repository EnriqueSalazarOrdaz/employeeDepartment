using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Models;
using eManager.Domain;

namespace eManager.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;
        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create(int deparmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.departmentId = deparmentId;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid) { 
                var department = _db.Deparments.Single(x => x.id == viewModel.departmentId);
                Employee myEmployee = new Employee();
                myEmployee.name = viewModel.name;
                myEmployee.HireDate = viewModel.HireDate;
                department.Employees.Add(myEmployee);
                _db.Save();
                return RedirectToAction("Detail", "Dep", new { id = viewModel.departmentId });
            }
            return View(viewModel);
        }
    }
}