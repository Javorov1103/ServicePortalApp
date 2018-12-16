namespace ServiceApp.Data.Models
{
    using ServiceApp.Web.Areas.Identity.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Order : BaseModel<int>
    {
        public Order()
        {
            this.Raws = new List<OrderRaw>();
        }

        public DateTime DateOfCreation { get; set; }

        public ServiceAppUser Service { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }

        public IList<OrderRaw> Raws { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Raws.Sum(x => x.TotalPrice);
            }
        }

        public bool IsActive { get; set; }
    }
}