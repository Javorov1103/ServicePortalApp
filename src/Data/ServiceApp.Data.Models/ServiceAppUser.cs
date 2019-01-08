namespace ServiceApp.Web.Areas.Identity.Data
{
    using Microsoft.AspNetCore.Identity;
    using ServiceApp.Data.Models;
    using System.Collections.Generic;

    // Add profile data for application users by adding properties to the ServiceAppUser class
    public class ServiceAppUser : IdentityUser
    {
        public ServiceAppUser()
        {
            this.Offers = new HashSet<Offer>();
            this.Orders = new HashSet<Order>();
            this.Clinets = new HashSet<CarOwner>();
            this.Obligations = new List<Obligation>();
            this.Warehouse = new Warehouse();
        }

        public string Name { get; set; }

        public string Bulstat { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string MRP { get; set; }

        public IList<Obligation> Obligations { get; set; }

        public int WarehouseId { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<CarOwner> Clinets { get; set; }

    }
}
