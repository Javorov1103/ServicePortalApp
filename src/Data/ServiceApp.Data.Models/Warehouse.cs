using ServiceApp.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Data.Models
{
    public class Warehouse : BaseModel<int>
    {
        public Warehouse()
        {
            this.Parts = new List<Part>();
        }

        public virtual ServiceAppUser Service { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
