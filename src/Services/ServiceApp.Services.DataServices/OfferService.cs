
using ServiceApp.Data.Common;
using ServiceApp.Data.Models;
using ServiceApp.Services.DataServices.Contracts;
using ServiceApp.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceApp.Services.Models.Offers;
using AutoMapper;

namespace ServiceApp.Services.DataServices
{
    public class OfferService : BaseService, IOfferService
    {
        private IRepository<Offer> offerRepository { get; set; }


        public OfferService(
            IRepository<Part> partRepository, IMapper mapper)
            : base (mapper)
        {
            this.offerRepository = offerRepository;
        }

        public IEnumerable<OffersShortViewModel> All(string id)
        {
           
            var offers = this.offerRepository.All().Where(x=>x.Service.Id == id).Select(o => mapper.Map<OffersShortViewModel>(o)).ToList();

            return offers;
        }

        public async Task<int> Create(OfferCreateViewModel input)
        {
            return 0;
        }

        public OfferDetailsViewModel GetById(int id)
        {
            var offer = offerRepository.All()
                .Select(o=>mapper.Map<OfferDetailsViewModel>(o))
                .FirstOrDefault(o => o.Id == id);

            return offer;
        }
    }
}
