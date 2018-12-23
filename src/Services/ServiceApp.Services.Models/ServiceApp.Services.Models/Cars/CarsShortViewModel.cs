using AutoMapper;
using ServiceApp.Data.Models;
using ServiceApp.Services.Mapping;

namespace ServiceApp.Services.Models.Cars
{
    public class CarsShortViewModel : IMapFrom<Car>, IHaveCustomMappings
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string RegistrationNumber { get; set; }

        public string VinNumber { get; set; }

        public string CarOwner { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Car, CarsShortViewModel>()
                .ForMember(x => x.CarOwner, y => y.MapFrom(c => c.CarOwner.Name));
        }
    }
}
