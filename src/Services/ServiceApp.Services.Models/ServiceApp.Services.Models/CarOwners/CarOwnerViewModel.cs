using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Services.Models.CarOwner
{
    public class CarOwnerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Bulstat { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Obligation { get; set; }

        public string Telephone { get; set; }
    }
}
