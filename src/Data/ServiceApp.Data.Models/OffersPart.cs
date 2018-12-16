namespace ServiceApp.Data.Models
{
    public class OffersPart:BaseModel<int>
    {
        public int PartId { get; set; }

        public Part Part { get; set; }

        public int OfferId { get; set; }

        public Offer Offer { get; set; }
    }
}