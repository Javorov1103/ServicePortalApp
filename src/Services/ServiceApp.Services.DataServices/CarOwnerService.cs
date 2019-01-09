namespace ServiceApp.Services.DataServices
{
    using System.Threading.Tasks;
    using AutoMapper;
    using ServiceApp.Data.Common;
    using ServiceApp.Data.Models;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Services.Models.CarOwner;
    using System.Linq;
    using System.Collections.Generic;
    using ServiceApp.Web.Areas.Identity.Data;

    public class CarOwnerService : ICarOwnerService
    {
        private IRepository<CarOwner> carOwnerRepository;
        private IRepository<ServiceAppUser> userRepository;
        private IMapper mapper;

        public CarOwnerService(IRepository<CarOwner> carOwnerRepository, IMapper mapper, IRepository<ServiceAppUser> userRepository)
        {
            this.carOwnerRepository = carOwnerRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<int> Create(CarOwnerCreateViewModel model, ServiceAppUser user)
        {

            var carOwner = mapper.Map<CarOwner>(model);
            var coUser = this.userRepository.All().FirstOrDefault(u => u.Id == user.Id);
            carOwner.AutoService = coUser;
            ;

            await this.carOwnerRepository.AddAsync(carOwner);
            await this.carOwnerRepository.SaveChangesAsync();

            var id = carOwner.Id;

            return id;
        }

       

        public CarOwner GetById(int id)
        {
            var carOwner = this.carOwnerRepository.QueryObjectGraph(cw=>cw.Id==id,"Cars").FirstOrDefault();
            

            return carOwner;
        }

        public IEnumerable<CarOwnerViewModel> GetAll(string id)
        {
            
            var all = this.carOwnerRepository.All().ToList().Where(x=>x.ServiceAppUserId ==id).Select(co => mapper.Map<CarOwnerViewModel>(co));

            return all;
        }
    }
}
