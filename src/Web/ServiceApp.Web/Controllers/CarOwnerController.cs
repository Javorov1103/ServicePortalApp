namespace ServiceApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models.CarOwner;
    using ServiceApp.Web.Areas.Identity.Data;
    using System.Threading.Tasks;

    [Authorize]
    public class CarOwnerController : Controller
    {
        private ICarOwnerService carOwnerService;
        private UserManager<ServiceAppUser> userManager;

        public CarOwnerController(ICarOwnerService carOwnerService, UserManager<ServiceAppUser> userManager)
        {
            this.carOwnerService = carOwnerService;
            this.userManager = userManager;
        }
        

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarOwnerCreateViewModel model)
        {
            ServiceAppUser currentUser = await this.userManager.GetUserAsync(HttpContext.User);

            var id = await this.carOwnerService.Create(model,currentUser);

            return this.RedirectToAction("Details", new { id });
        }

        public IActionResult Details(int id)
        {
            var carOwner = carOwnerService.GetById(id);

            return this.View(carOwner);
        }

        public IActionResult GetAll()
        {
            var carOwners = this.carOwnerService.GetAll();

            return this.View(carOwners);
        }
    }
}
