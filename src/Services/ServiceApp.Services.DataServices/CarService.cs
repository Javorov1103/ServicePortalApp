﻿namespace ServiceApp.Services.DataServices
{
    using AutoMapper;
    using ServiceApp.Data.Common;
    using ServiceApp.Data.Models;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models.Cars;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CarService : ICarService
    {
        private IRepository<Car> carReposotiry;
        private IRepository<CarOwner> carOwnerReposotiry;
        private IMapper mapper;

        public CarService(IRepository<Car> carReposotiry,IMapper mapper, IRepository<CarOwner> carOwnerReposotiry)
        {
            this.carReposotiry = carReposotiry;
            this.mapper = mapper;
            this.carOwnerReposotiry = carOwnerReposotiry;
        }

        public IEnumerable<CarShortViewModel> All(string id)
        {
            var cars = this.carReposotiry.All().Where(c=>c.CarOwner.AutoService.Id == id).Select(x=>mapper.Map<CarShortViewModel>(x)).ToList();

            return cars;
        }

        public async Task<int> Create(CarCreateViewModel input)
        {
            var carOwner = carOwnerReposotiry.All().FirstOrDefault(x => x.Id == input.CarOwnerId);
            var car = mapper.Map<Car>(input);
            car.CarOwner = carOwner;

            await this.carReposotiry.AddAsync(car);
            await this.carReposotiry.SaveChangesAsync();

            var id = car.Id;

            return id;
        }

        public CarDetailsViewModel GetById(int id)
        {
            var car = this.carReposotiry.All().Select(c=>mapper.Map<CarDetailsViewModel>(c)).FirstOrDefault(x=>x.Id == id);

            return car;
        }
    }
}
