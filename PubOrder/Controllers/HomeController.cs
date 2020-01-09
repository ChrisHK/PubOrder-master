using System.Web.Mvc;
using PubOrder.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Collections.Generic;


namespace PubOrder.Controllers {
    public class HomeController : Controller {

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
