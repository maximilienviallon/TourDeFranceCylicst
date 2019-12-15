using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using claimy_appt.Models;

namespace claimy_appt.Controllers
{
    public class SingInController : Controller
    {
        // GET: SingIn
        public ActionResult SignIn()
        {
            var signIn = new SignIn() { ID = "email address", Password = "password"};
            
            return View(signIn);
        }
    }
}