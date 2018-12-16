using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Services.DataServices.Contracts;

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
    }
}