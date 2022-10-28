using CrownHotelListing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Core.Interfaces
{
    public interface ICountryService
    {
        Task<IList<Country>> GetAllCountriesAsync();
    }
}
