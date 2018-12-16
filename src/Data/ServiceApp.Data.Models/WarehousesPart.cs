namespace ServiceApp.Data.Models
{
    public class WarehousesPart : BaseModel<int>
    {
        public int PartId { get; set; }
        public Part Part { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}