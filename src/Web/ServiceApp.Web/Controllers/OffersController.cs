namespace ServiceApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models.Offers;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [Authorize]
    public class OffersController : Controller
    {
        private IOfferService offerService;
        private ICarService carService;
        private IPartService partService;
        private readonly IUserService userService;

        public OffersController(IOfferService offerService, ICarService carService, IPartService partService,
            IUserService userService)
        {
            this.offerService = offerService;
            this.carService = carService;
            this.partService = partService;
            this.userService = userService;
        }

        public IActionResult GetAll()
        {
            var offers = this.offerService.GetAll(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(offers);
        }

        public IActionResult Create()
        {
            this.ViewData["carsRegisterNums"] = this.carService.GetAll(this.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .Select(
                x=>new SelectListItem
                {
                    Value = x.RegistrationNum,
                    Text= x.RegistrationNum
                }
                );

            var parts = this.partService.GetAllFromWarehouse(this.userService.GetById(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).WarehouseId).Select(o=>o.Description);
            ViewBag.parts = parts;

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OfferCreateViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var id = await offerService.Create(input);

            return RedirectToAction("Details", new { id = id });
        }
        

        public IActionResult Details(int id)
        {
            var offer = offerService.GetById(id);

            return this.View(offer);
        }
    }
}