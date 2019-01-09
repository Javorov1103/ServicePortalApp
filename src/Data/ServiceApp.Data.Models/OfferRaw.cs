namespace ServiceApp.Data.Models
{
    public class OfferRaw : BaseModel<int>
    {
        public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }

        public int PartId { get; set; }
        public virtual Part Part { get; set; }

        public int Count{ get; set; }

        public decimal PriceOfParts
        {
            get
            {
                return this.Part.SellingPrice * this.Count;
            }
        }

        public decimal PriceOfWork { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.PriceOfParts + this.PriceOfWork;
            }
        }

    }
}
