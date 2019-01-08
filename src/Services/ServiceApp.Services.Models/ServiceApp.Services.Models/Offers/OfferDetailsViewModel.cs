using ServiceApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceApp.Services.Models.Offers
{
    public class OfferDetailsViewModel 
    {
        public OfferDetailsViewModel()
        {
            this.Raws = new List<OfferRawDetailViewModel>().AsQueryable();
        }
        public int Id { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public string CarRegistrationNumber { get; set; }

        public string CarVinNumber { get; set; }

        public IQueryable<OfferRawDetailViewModel> Raws { get; set; }

        public decimal TotalPrice { get; set; }

    }
}
