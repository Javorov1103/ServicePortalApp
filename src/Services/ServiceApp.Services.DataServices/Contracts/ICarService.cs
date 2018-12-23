using ServiceApp.Services.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services.DataServices.Contracts
{
    public interface ICarService
    {
        IEnumerable<CarsShortViewModel> All(string name);

        Task<int> Create(CarCreateViewModel input);

        CarDetailsViewModel GetById(int id);

    }
}
