namespace ServiceApp.Services.DataServices
{
    using ServiceApp.Data.Common;
    using ServiceApp.Data.Models;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ServiceApp.Services.Models.Offers;
    using AutoMapper;
    using System;

    public class OfferService : BaseService, IOfferService
    {
        private IRepository<Offer> offerRepository { get; set; }
        private IRepository<Car> carsRepository { get; }


        public OfferService(
            IRepository<Offer> offerRepository, IMapper mapper, IRepository<Car> carsRepository)
            : base(mapper)
        {
            this.offerRepository = offerRepository;
            this.carsRepository = carsRepository;
        }

        public IEnumerable<OffersShortViewModel> GetAll(string id)
        {
            var offers = new List<OffersShortViewModel>();

            var offersFromDB = this.offerRepository.All().Where(x => x.Service.Id == id);
            //.Select(o => mapper.Map<OffersShortViewModel>(o)).ToList();

            if (!offersFromDB.Any())
            {
                return offers;
            }
            else
            {
                offers = offersFromDB.Select(o => mapper.Map<OffersShortViewModel>(o)).ToList();
            }

            return offers;
        }

        public async Task<int> Create(OfferCreateViewModel input)
        {
            var car = carsRepository.All().FirstOrDefault(x => x.RegistrationNum == input.CarRegistrationNumber);
            
            var offer = new Offer()
            {
                Car = car,
                DateOfCreation = DateTime.UtcNow,
            };

            foreach(var raw in input.Raws)
            {
                
            }

            await this.offerRepository.AddAsync(offer);
            await this.offerRepository.SaveChangesAsync();
            
            //Debug
            return offer.Id;
        }

        public OfferDetailsViewModel GetById(int id)
        {
            var offer = offerRepository.All()
                .Select(o => mapper.Map<OfferDetailsViewModel>(o))
                .FirstOrDefault(o => o.Id == id);

            return offer;
        }
    }
}
