namespace ServiceApp.Data.Models
{
    public class OrderRaw : BaseModel<int>
    {
        public int OrderrId { get; set; }
        public Order Order { get; set; }

        public int PartId { get; set; }
        public Part Part { get; set; }

        public int Count { get; set; }

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
