
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Services.DataServices.Contracts;
using System.Security.Claims;

namespace ServiceApp.Web.Controllers
{
    [Authorize]
    public class CarsController : Controller
    {
        private ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        public IActionResult GetAll()
        {
            var cars = this.carService.All(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(cars);
        }
    }
}