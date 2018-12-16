namespace ServiceApp.Data.Models
{
    public class OrdersPart : BaseModel<int>
    {
        public int PartId { get; set; }

        public Part Part { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}