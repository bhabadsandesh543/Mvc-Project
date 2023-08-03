using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;

namespace mvc_project.Controllers
{
    public class AsylumSeekerController
    {
        public ActionResult Login()
        {
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
             return RedirectToAction("Index","AsylumSeeker");
        }

        private ActionResult RedirectToAction(string v1, string v2)
        {
             throw new NotImplementedException();
        }
    }
}
