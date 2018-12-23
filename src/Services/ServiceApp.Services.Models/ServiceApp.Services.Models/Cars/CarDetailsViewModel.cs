using AutoMapper;
using ServiceApp.Data.Models;
using ServiceApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Services.Models.Cars
{
    public class CarDetailsViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public string VinNumber { get; set; }

        public string CarOwner { get; set; }

        public string CarOwnerEmail { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Car, CarDetailsViewModel>()
                .ForMember(x => x.CarOwner, y => y.MapFrom(c => c.CarOwner.Name))
                .ForMember(x => x.CarOwnerEmail , y=>y.MapFrom(c=>c.CarOwner.Email));
        }
    }
}
