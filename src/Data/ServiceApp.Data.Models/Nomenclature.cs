namespace ServiceApp.Data.Models
{
    using ServiceApp.Web.Areas.Identity.Data;
    using System.Collections.Generic;

    public class Nomenclature : BaseModel<int>
    {
        public Nomenclature()
        {
            this.Parts = new List<Part>();
        }

        public virtual ServiceAppUser Service { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
