using CoolMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoolMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        TestEntities conn = new TestEntities();
        public ActionResult Index(EmployeeViewModel model)
        {
            //var model = conn.CoolTables.ToList();
            //return View(model);

            model.employees = conn.CoolTables
                .Where(

                x =>

                (model.Name == null || x.Name.Contains(model.Name))

                && (model.Branch == null || x.Branch.Contains(model.Branch))
                )
                .OrderBy(x=>x.Id)
                .Skip((model.Page-1)*model.PageSize)
                .Take(model.PageSize)
                .ToList();

            // total records for paging
            model.TotalRecords = conn.CoolTables
                .Count(x =>
                    (model.Name == null || x.Name.Contains(model.Name))
                    );

            return View(model);  

        }
    
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(CoolTable model)
        {
            if (ModelState.IsValid)
            {
                conn.CoolTables.Add(model);
                conn.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

      
    }
}