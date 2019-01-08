using AutoMapper;

namespace ServiceApp.Services.DataServices
{
    public abstract class BaseService
    {
        protected IMapper mapper;

        public BaseService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        
    }
}
