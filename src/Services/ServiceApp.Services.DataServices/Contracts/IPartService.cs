namespace ServiceApp.Services.DataServices.Contracts
{
    using ServiceApp.Data.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPartService
    {
        IEnumerable<Part> GetAllFromWarehouse(int warehouseId);
        IEnumerable<Part> GetAllFromNumenclature(int numenclatureId);

        Part GetByIdFromWarehouse(int id);
        Part GetByIdFromNumenclature(int id);

        Task<int> AddToNumenclature(Part part, int NumenclatureId);
        Task<int> AddToWarehouse(Part part, int WarehouseId);
    }
}
