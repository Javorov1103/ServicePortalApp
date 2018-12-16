using ServiceApp.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Data.Models
{
    public class Obligation : BaseModel<int>
    {
        public ServiceAppUser Service { get; set; }

        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }

        public decimal Amount { get; set; }
    }
}
