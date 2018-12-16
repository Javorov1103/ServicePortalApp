namespace ServiceApp.Data.Models
{
    using ServiceApp.Web.Areas.Identity.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Offer : BaseModel<int>
    {
        public Offer()
        {
            this.Raws = new List<OfferRaw>();
        }

        public DateTime DateOfCreation { get; set; }

        public ServiceAppUser Service { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        public ICollection<OfferRaw> Raws { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Raws.Sum(x =>x.TotalPrice);
            }
        }
    } 
}