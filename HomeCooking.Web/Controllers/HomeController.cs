using HomeCooking.Core;
using HomeCooking.Web.ViewModelBuilders.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeCooking.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModelBuilder builder = new HomeViewModelBuilder();
            return View(builder.Build());
        }

        public ActionResult Test()
        {
            AccountServices service = new AccountServices();
            service.Test();
            return RedirectToAction("Index");
        }
    }
}