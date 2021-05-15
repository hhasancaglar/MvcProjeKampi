using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var rslt1 = c.Categories.Count();
            var rslt2 = c.Headings.Count(x => x.Category.CategoryID == 4011);
            var rslt3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            var rslt4 = c.Headings.Max(x => x.Category.CategoryName);
            var rslt5 = c.Categories.Count(x => x.CategoryStatus == true);
            var rslt6 = c.Categories.Count(x => x.CategoryStatus == false);

            ViewBag.CategoryCount = rslt1;
            ViewBag.Heading = rslt2;
            ViewBag.Writer = rslt3;
            ViewBag.MaxHeading = rslt4;
            ViewBag.Status = (rslt5 - rslt6);

            return View();
        }
    }
}