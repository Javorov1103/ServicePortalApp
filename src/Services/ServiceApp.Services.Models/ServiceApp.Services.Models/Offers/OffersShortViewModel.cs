namespace ServiceApp.Services.Models
{
    using ServiceApp.Data.Models;
    using System;

    public class OffersShortViewModel 
    {
        public string CarMake { get; set; }

        public string CarRegistrationNumber { get; set; }

        public decimal TotalPrice { get;}

        public DateTime DateOfCreation { get; set; }
        
    }
}
