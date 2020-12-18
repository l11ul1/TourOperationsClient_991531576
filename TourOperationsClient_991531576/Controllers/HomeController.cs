using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourOperationsClient_991531576.ServiceReference1;

namespace TourOperationsClient_991531576.Controllers
{
    public class HomeController : Controller
    {

        DBOperationsClient client = new DBOperationsClient("BasicHttpBinding_DBOperations");

        public ActionResult ShowAll()
        {
            List<TourInfo> tourInfos = client.RetrieveTourInfo().ToList();
            return View(tourInfos);
        }

        public ActionResult Index()
        {
            return View();
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