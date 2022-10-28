using System.Collections.Generic;

namespace CrownHotelListing.Core.DTOs
{
    public class CountryResponseDto : CountryRequestDto
    {
        public int Id { get; set; }
        public IList<HotelResponseDto> Hotels { get; set; }
    }
}
