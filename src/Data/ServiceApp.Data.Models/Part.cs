namespace ServiceApp.Data.Models
{
    using System.Collections.Generic;

    public class Part : BaseModel<int>
    {
        public Part()
        {
            this.Orders = new List<OrdersPart>();
            this.Offers = new List<OffersPart>();
            this.Warehouses = new List<WarehousesPart>();
            this.DeliveryRaws = new List<DeliveryRaw>();
        }

        public string Description { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal DeliveryPrice { get; set; }

        public ICollection<DeliveryRaw> DeliveryRaws { get; set; }

        public ICollection<OrdersPart> Orders { get; set; }

        public ICollection<OffersPart> Offers { get; set; }

        public ICollection<WarehousesPart> Warehouses { get; set; }
    }
}
