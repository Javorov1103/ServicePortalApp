using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Services.DataServices.Contracts;
using ServiceApp.Services.Models.Offers;
using System.Threading.Tasks;

namespace ServiceApp.Web.Controllers
{
    [Authorize]
    public class OffersController : Controller
    {
        public IOfferService offerService { get; set; }

        public OffersController(IOfferService offerService)
        {
            this.offerService = offerService;
        }

        public IActionResult GetAll()
        {
            var offers = this.offerService.All();
            return View(offers);
        }

        public IActionResult Create()
        {
            var model = new OfferCreateViewModel();
            return this.View(model);
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