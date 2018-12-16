using ServiceApp.Data.Models;
using ServiceApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceApp.Services.Models.Offers
{
    public class OfferCreateViewModel : IMapTo<Offer>
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
