namespace ServiceApp.Services.Models.Offers
{
    using System.Collections.Generic;

    public class OfferCreateViewModel 
    {
        public OfferCreateViewModel()
        {
            this.Raws = new List<OfferRawCreateViewModel>();
        }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public string CarRegistrationNumber { get; set; }

        public string CarVinNumber { get; set; }

        public string CarOwner { get; set; }

        public ICollection<OfferRawCreateViewModel> Raws { get; set; }


    }
}
