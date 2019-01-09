namespace ServiceApp.Data.Models
{
    public class DeliveryRaw : BaseModel<int>
    {
        public virtual Delivery Delivery { get; set; }

        public Part Part { get; set; }

        public int Count { get; set; }

        public decimal PartPrice { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Count * this.PartPrice;
            }
        }
    }
}