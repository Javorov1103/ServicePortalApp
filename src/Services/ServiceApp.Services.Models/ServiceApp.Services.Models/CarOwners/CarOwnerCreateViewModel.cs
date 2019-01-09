namespace ServiceApp.Services.Models.CarOwner
{
    using System.ComponentModel.DataAnnotations;
    using ServiceApp.Data.Models;

    public class CarOwnerCreateViewModel 
    {
        public string Name { get; set; }

        [MaxLength(9)]
        [MinLength(9)]
        public string Bulstat { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string MRP { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Telephone { get; set; }

        
    }
}
