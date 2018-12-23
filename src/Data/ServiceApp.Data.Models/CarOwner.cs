namespace ServiceApp.Data.Models
{
    using ServiceApp.Web.Areas.Identity.Data;
    using System.Collections.Generic;

    public class CarOwner : BaseModel<int>
    {
        public CarOwner()
        {
            this.Cars = new HashSet<Car>();
        }

        public string Name { get; set; }

        public string Bulstat { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string MRP { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public ICollection<Car> Cars { get; set; }

        public decimal Obligation { get; set; }

        public ServiceAppUser Service { get; set; }
    }
}