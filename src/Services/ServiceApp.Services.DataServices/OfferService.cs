using ServiceApp.Services.Mapping;
using ServiceApp.Data.Common;
using ServiceApp.Data.Models;
using ServiceApp.Services.DataServices.Contracts;
using ServiceApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.Services.Models.Offers;

namespace ServiceApp.Services.DataServices
{
    public class OfferService : IOfferService
    {
        private IRepository<Offer> offerRepository { get; set; }
        private IRepository<Car> carRepository { get; set; }
        private IRepository<CarOwner> carOwnerRepository { get; set; }
        private IRepository<Part> partRepository { get; set; }

        public OfferService(
            IRepository<Offer> offerRepository,
            IRepository<Car> carRepository,
            IRepository<CarOwner> carOwnerRepository,
            IRepository<Part> partRepository)
        {
            this.offerRepository = offerRepository;
            this.carRepository = carRepository;
            this.carOwnerRepository = carOwnerRepository;
            this.partRepository = partRepository;
        }

        public IEnumerable<OffersShortViewModel> All()
        {
            var offers = this.offerRepository.All().To<OffersShortViewModel>().ToList();

            return offers;
        }

        public async Task<int> Create(OfferCreateViewModel input)
        {
            var carOwner = new CarOwner()
            {
                Name = input.CarOwner,
            };
            var car = new Car()
            {
                Make = input.CarMake,
                Model = input.CarModel,
                RegistrationNum = input.CarRegistrationNumber,
                VinNumber = input.CarVinNumber,
            };

            var raws = new List<OfferRaw>();

            foreach (var raw in input.Raws)
            {
                var newRaw = new OfferRaw();

                if (partRepository.All().Any(p => p.Code == raw.PartCode))
                {
                    newRaw.Part = partRepository.All().FirstOrDefault(p => p.Code == raw.PartCode);
                }
                else
                {
                    var part = new Part()
                    {
                        Code = raw.PartCode,
                        Description = raw.PartDesciption,
                        SellingPrice = raw.PartPrice,
                    };
                    await partRepository.AddAsync(part);
                    await partRepository.SaveChangesAsync();


                    newRaw.Part = part;
                }

                raws.Add(newRaw);
            }

            var offer = new Offer()
            {
                DateOfCreation = DateTime.Now,
                Raws = raws
            };

            if (!this.carOwnerRepository.Contains(carOwner))
            {
                car.CarOwner = carOwner;
                await this.carOwnerRepository.AddAsync(carOwner);
            }
            else
            {
                car.CarOwner = carOwnerRepository.All().FirstOrDefault(x => x.Name == input.CarOwner);
            }

            if (!this.carRepository.Contains(car))
            {
                offer.Car = car;
                await this.carRepository.AddAsync(car);
            }
            else
            {
                offer.Car = carRepository.All().FirstOrDefault(c => c.VinNumber == input.CarVinNumber);
            }

            await this.offerRepository.AddAsync(offer);
            await this.offerRepository.SaveChangesAsync();

            return offer.Id;
        }

        public OfferDetailsViewModel GetById(int id)
        {
            var offer = offerRepository.All().To<OfferDetailsViewModel>().FirstOrDefault(o => o.Id == id);

            return offer;
        }
    }
}
