using ServiceApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Services.Models.Offers
{
    public class OfferRawCreateViewModel 
    {
        public string PartCode { get; set; }

        public string PartDesciption { get; set; }

        public decimal PartPrice { get; set; }

        public int PartCount { get; set; }
        
        public decimal PriceOfWork { get; set; }

        

    }
}
