namespace ServiceApp.Services.Models.Offers
{
    using System.Collections.Generic;

    public class OfferCreateViewModel 
    {
        public OfferCreateViewModel()
        {
            this.Raws = new List<OfferRawCreateViewModel>();
        }

        public string CarRegistrationNumber { get; set; }

        public ICollection<OfferRawCreateViewModel> Raws { get; set; }


    }
}
