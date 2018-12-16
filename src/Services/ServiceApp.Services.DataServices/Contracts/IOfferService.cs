using ServiceApp.Services.Models;
using ServiceApp.Services.Models.Offers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services.DataServices.Contracts
{
    public interface IOfferService
    {
        IEnumerable<OffersShortViewModel> All();

        Task<int> Create(OfferCreateViewModel input);

        OfferDetailsViewModel GetById(int id);
    }
}
