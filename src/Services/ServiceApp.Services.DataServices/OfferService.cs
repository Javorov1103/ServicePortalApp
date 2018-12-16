using ServiceApp.Services.Mapping;
using ServiceApp.Data.Common;
using ServiceApp.Data.Models;
using ServiceApp.Services.DataServices.Contracts;
using ServiceApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceApp.Services.DataServices
{
    public class OfferService : IOfferService
    {
        public IRepository<Offer> offerRepository { get; set; }

        public OfferService(IRepository<Offer> offerRepository)
        {
            this.offerRepository = offerRepository;
        }

        public IEnumerable<OffersShortViewModel> All()
        {
            var offers = this.offerRepository.All().To<OffersShortViewModel>().ToList();

            return offers;
        }
    }
}
