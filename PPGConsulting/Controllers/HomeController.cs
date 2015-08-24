using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPGConsulting.ViewModels;
using PPGConsulting.DAL;

namespace PPGConsulting.Controllers
{
    public class HomeController : Controller
    {
        private ConsultingContext db = new ConsultingContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<TitleGroup> data = from empolyee in db.Employees
                                                   group empolyee by empolyee.Title into dateGroup
                                                   select new TitleGroup()
                                                   {
                                                       Title = dateGroup.Key,
                                                       EmployeeCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}