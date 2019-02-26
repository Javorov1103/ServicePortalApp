namespace ServiceApp.Services.DataServices.Contracts
{
    using ServiceApp.Web.Areas.Identity.Data;

    public interface IUserService
    {
        ServiceAppUser GetById(string id);
    }
}
