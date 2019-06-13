using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index() => View();
        public PartialViewResult Login()
        {
            return PartialView("_Login");
        }
    }
}