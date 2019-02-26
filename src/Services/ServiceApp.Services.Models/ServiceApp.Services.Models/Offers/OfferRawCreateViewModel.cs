using ServiceApp.Data.Models;

namespace ServiceApp.Services.Models.Offers
{
    public class OfferRawCreateViewModel 
    {
        public string Part { get; set; }

        public int Count { get; set; }
        
        public decimal PriceOfWork { get; set; }

    }
}
