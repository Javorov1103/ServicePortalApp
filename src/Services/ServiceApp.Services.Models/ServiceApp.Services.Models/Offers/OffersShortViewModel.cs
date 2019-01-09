namespace ServiceApp.Services.Models
{
    using ServiceApp.Data.Models;
    using System;

    public class OffersShortViewModel 
    {
        public int Id { get; set; }

        public string CarMake { get; set; }

        public string RegistrationNum { get; set; }

        public decimal TotalPrice { get;}

        public DateTime DateOfCreation { get; set; }
        
    }
}
