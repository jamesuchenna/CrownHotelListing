using CrownHotelListing.Core.Interfaces;
using CrownHotelListing.Domain.Model;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CountryService(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IList<Country>> GetAllCountriesAsync()
        {
            try
            {
                _logger.Information("Attempting to retrieve all countries records");
                var countries = await _unitOfWork.Countries.GetAllAsync();

                _logger.Information("All countries retrieved");
                return countries;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occurred while attempting to retrieve countries records.");
                throw;
            }
        }
    }
}
