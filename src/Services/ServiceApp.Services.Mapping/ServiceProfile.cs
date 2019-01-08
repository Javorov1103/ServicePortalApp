using AutoMapper;
using ServiceApp.Data.Models;
using ServiceApp.Services.Models;
using ServiceApp.Services.Models.CarOwner;
using ServiceApp.Services.Models.Cars;
using ServiceApp.Services.Models.Offers;

namespace ServiceApp.Services.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<CarOwnerCreateViewModel, CarOwner>();
            CreateMap<CarOwner, CarOwnerViewModel>();
            
            CreateMap<Offer, OffersShortViewModel>();
            CreateMap<Offer, OfferDetailsViewModel>();

            CreateMap<Car, CarShortViewModel>();
            CreateMap<CarCreateViewModel, Car>();
            CreateMap<Car, CarDetailsViewModel>()
                .ForMember(dest=>dest.CarOwnerName,opt=>opt.MapFrom(src=>src.CarOwner.Name))
                .ForMember(dest=>dest.CarOwnerEmail, opt=>opt.MapFrom(src=>src.CarOwner.Email));
        }
    }
}
