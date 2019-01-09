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
        public IOfferService offerService { get; set; }
        public ICarService carService { get; set; }

        public OffersController(IOfferService offerService, ICarService carService)
        {
            this.offerService = offerService;
            this.carService = carService;
        }

        public IActionResult GetAll()
        {
            var offers = this.offerService.GetAll(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(offers);
        }

        public IActionResult Create()
        {
            this.ViewData["carsRegisterNums"] = this.carService.All(this.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .Select(
                x=>new SelectListItem
                {
                    Value = x.RegistrationNum,
                     Text= x.RegistrationNum
                }
                );

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

            return RedirectToAction("Ditails", new { id = id });
        }
        

        public IActionResult Details(int id)
        {
            var offer = offerService.GetById(id);

            return this.View(offer);
        }
    }
}