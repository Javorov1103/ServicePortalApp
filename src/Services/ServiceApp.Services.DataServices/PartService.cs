using ServiceApp.Data.Common;
using ServiceApp.Data.Models;
using ServiceApp.Services.DataServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Services.DataServices
{
    public class PartService : IPartService
    {
        private IRepository<Part> partRepository;
        private readonly IRepository<Nomenclature> nomenclatureRepository;

        public PartService(IRepository<Part> partRepository, IRepository<Nomenclature> nomenclatureRepository)
        {
            this.partRepository = partRepository;
            this.nomenclatureRepository = nomenclatureRepository;
        }

        public async Task<int> AddToNumenclature(Part part, int nomenclatureId)
        {
            var currNomenclature = this.nomenclatureRepository.All().FirstOrDefault(n => n.Id == nomenclatureId);
            part.Nomenclature = currNomenclature;
            await this.partRepository.AddAsync(part);
            await this.partRepository.SaveChangesAsync();

            return part.Id;
        }

        public async Task<int> AddToWarehouse(Part part, int warehouseId)
        {
            part.Warehouse.Id = warehouseId;
            await this.partRepository.AddAsync(part);
            await this.partRepository.SaveChangesAsync();

            return part.Id;
        }

        public IEnumerable<Part> GetAllFromNumenclature(int numenclatureId)
        {
            return this.partRepository.All().Where(x => x.Nomenclature.Id == numenclatureId);
        }

        public IEnumerable<Part> GetAllFromWarehouse(int warehouseId)
        {
            return this.partRepository.All().Where(x => x.Warehouse.Id == warehouseId);
        }

        public Part GetByIdFromNumenclature(int id)
        {
            return this.partRepository.All().FirstOrDefault(x => x.Nomenclature.Id == id);
        }

        public Part GetByIdFromWarehouse(int id)
        {
            return this.partRepository.All().FirstOrDefault(x => x.Warehouse.Id == id);
        }
    }
}
