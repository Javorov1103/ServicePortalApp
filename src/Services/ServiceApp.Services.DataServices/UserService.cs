namespace ServiceApp.Services.DataServices
{
    using ServiceApp.Data.Common;
    using ServiceApp.Services.DataServices.Contracts;
    using ServiceApp.Web.Areas.Identity.Data;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly IRepository<ServiceAppUser> userRepository;

        public UserService(IRepository<ServiceAppUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public ServiceAppUser GetById(string id)
        {
            return this.userRepository.All().FirstOrDefault(u => u.Id == id);
        }
    }
}
