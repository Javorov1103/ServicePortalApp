namespace ServiceApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ServiceApp.Data.Models;
    using ServiceApp.Services.DataServices.Contracts;
    using System.Security.Claims;
    using System.Threading.Tasks;

    [Authorize]
    public class PartsController : Controller
    {
        private readonly IPartService partService;
        private readonly IUserService userService;

        public PartsController(IPartService partService, IUserService userService)
        {
            this.partService = partService;
            this.userService = userService;
        }

        
        public IActionResult Create()
        {
             return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Part part)
        {
            var user = this.userService.GetById(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            int nomenclatureId = this.userService.GetById(this.User.FindFirstValue(ClaimTypes.NameIdentifier)).NomenclatureId;

            int partId = await this.partService.AddToNumenclature(part, nomenclatureId);

            return RedirectToAction("Details", new { id = partId });

        }


    }
}
