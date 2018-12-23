using ServiceApp.Data.Common;
using ServiceApp.Data.Models;
using ServiceApp.Services.DataServices.Contracts;
using ServiceApp.Services.Mapping;
using ServiceApp.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services.DataServices
{
    public class CarService : ICarService
    {
        private IRepository<Car> carReposotiry;

        public CarService(IRepository<Car> carReposotiry)
        {
            this.carReposotiry = carReposotiry;
        }

        public IEnumerable<CarsShortViewModel> All(string id)
        {
            var cars = this.carReposotiry.All().Where(c=>c.CarOwner.Service.Id == id).To<CarsShortViewModel>().ToList();

            return cars;
        }

        public Task<int> Create(CarCreateViewModel input)
        {
            throw new NotImplementedException();
        }

        public CarDetailsViewModel GetById(int id)
        {
            var car = this.carReposotiry.All().To<CarDetailsViewModel>().FirstOrDefault(x=>x.Id == id);

            return car;
        }
    }
}
