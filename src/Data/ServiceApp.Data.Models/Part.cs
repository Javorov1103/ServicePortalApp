namespace ServiceApp.Data.Models
{
    using System.Collections.Generic;

    public class Part : BaseModel<int>
    {
        public Part()
        {
            this.Offers = new List<OffersPart>();
        }

        public string Description { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal DeliveryPrice { get; set; }

        public Order Order { get; set; }

        public Warehouse Warehouse { get; set; }

        public Nomenclature Nomenclature { get; set; }

        public Delivery Delivery { get; set; }

        public ICollection<OffersPart> Offers { get; set; }
    }
}
