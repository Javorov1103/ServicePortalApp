using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Web.Areas.Identity.Data;
using ServiceApp.Web.Models;

namespace ServiceApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<ServiceAppUser> signInManager { get; set; }
        public HomeController(SignInManager<ServiceAppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
