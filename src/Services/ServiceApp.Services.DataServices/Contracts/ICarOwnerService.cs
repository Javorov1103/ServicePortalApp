namespace ServiceApp.Services.DataServices.Contracts
{
    using ServiceApp.Data.Models;
    using ServiceApp.Services.Models.CarOwner;
    using ServiceApp.Web.Areas.Identity.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICarOwnerService
    {
        Task<int> Create(CarOwnerCreateViewModel model, ServiceAppUser user);

        CarOwner GetById(int id);

        IEnumerable<CarOwnerViewModel> GetAll(string id);
    }
}
