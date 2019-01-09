using ServiceApp.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Data.Models
{
    public class Delivery : BaseModel<int>
    {
        public Delivery()
        {
            this.Raws = new List<DeliveryRaw>();
        }

        public virtual ServiceAppUser Service { get; set; }

        public virtual Supplier Supplier { get; set; }

        public ICollection<DeliveryRaw> Raws { get; set; }

    }
}
