using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Face3.Controllers
{
    public class AccountController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            //confirm user is not logged in
            string userName = User.Identity.Name;

            if (!string.IsNullOrEmpty(userName))
            {
                return Redirect("~/" + userName);
            }

            // return view
            return View();
        }
    }
}