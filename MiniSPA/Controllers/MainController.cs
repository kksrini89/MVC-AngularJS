using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniSPA.Models;

namespace MiniSPA.Controllers
{
    public class MainController : Controller
    {
        private MainModelBuilder builder = new MainModelBuilder();
        //
        // GET: /Main/
        public ActionResult Index()
        {
            return View(builder.MainModelData());
        }
    }
}