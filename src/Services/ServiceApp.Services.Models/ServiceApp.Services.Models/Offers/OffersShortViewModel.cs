namespace ServiceApp.Services.Models
{
    using AutoMapper;
    using ServiceApp.Services.Mapping;
    using ServiceApp.Data.Models;
    using System;

    public class OffersShortViewModel : IMapFrom<Offer>, IHaveCustomMappings
    {
        public string CarMake { get; set; }

        public string CarRegistrationNumber { get; set; }

        public decimal TotalPrice { get;}

        public DateTime DateOfCreation { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Offer, OffersShortViewModel>()
                .ForMember(x => x.CarMake, m => m.MapFrom(c => c.Car.Make))
                .ForMember(x => x.CarRegistrationNumber, m => m.MapFrom(c => c.Car.RegistrationNum));
        }
    }
}
