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
            var offers = this.offerRepository.All().ToList().Where(x => x.Service.Id == id).Select(o => mapper.Map<OffersShortViewModel>(o));

            return offers;
        }

        public async Task<int> Create(OfferCreateViewModel input)
        {
            var car = carsRepository.All().FirstOrDefault(x => x.RegistrationNum == input.CarRegistrationNumber);


            //OfferRaws to be splitted to part, count and price
            var offer = new Offer()
            {
                Car = car,
                DateOfCreation = DateTime.UtcNow,
            };



            return 0;
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
