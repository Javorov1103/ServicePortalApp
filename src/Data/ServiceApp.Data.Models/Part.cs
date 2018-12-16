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
        }

        public string Code { get; set; }

        public string Description { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal DeliveryPrice { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }



        public ICollection<OrdersPart> Orders { get; set; }

        public ICollection<OffersPart> Offers { get; set; }

        public ICollection<WarehousesPart> Warehouses { get; set; }
    }
}
