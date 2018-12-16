using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Data.Models
{
    public class Supplier : BaseModel<int>
    {
        public Supplier()
        {
            this.Parts = new List<Part>();
        }

        public string Name { get; set; }

        public string Bulstat { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string MRP { get; set; }

        public ICollection<Part> Parts { get; set; }


    }
}
