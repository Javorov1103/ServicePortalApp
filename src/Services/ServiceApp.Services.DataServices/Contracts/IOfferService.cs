using ServiceApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceApp.Services.DataServices.Contracts
{
    public interface IOfferService
    {
        IEnumerable<OffersShortViewModel> All();
    }
}
