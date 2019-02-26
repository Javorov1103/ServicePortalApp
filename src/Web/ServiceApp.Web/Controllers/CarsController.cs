namespace ServiceApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models.Cars;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [Authorize]
    public class CarsController : Controller
    {
        private ICarService carService;
        private ICarOwnerService carOwnerService;

        public CarsController(ICarService carService, ICarOwnerService carOwnerService)
        {
            this.carService = carService;
            this.carOwnerService = carOwnerService;
        }

        public IActionResult GetAll()
        {
            var cars = this.carService.GetAll(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(cars);
        }

        public IActionResult Create()
        {
            this.ViewData["CarOwners"] = this.carOwnerService.GetAll(this.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name
                }
                );

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarCreateViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var id =  await this.carService.Create(model);

            return this.RedirectToAction("Details", new { id = id });
        }


        public IActionResult Details(int id)
        {
            var car = carService.GetById(id);

            return this.View(car);
        }
    }
}