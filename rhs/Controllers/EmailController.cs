using rhs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rhs.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Registrar()
        {
            return View();
        }

        // POST: Email/Registrar
        [HttpPost]
        public ActionResult Registrar(Email email)
        {
            if (ModelState.IsValid)
            {
                using (var context = new EmailContext())
                {
                    context.Email.Add(email);
                    context.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }

            return View(email);
        }
    }
}