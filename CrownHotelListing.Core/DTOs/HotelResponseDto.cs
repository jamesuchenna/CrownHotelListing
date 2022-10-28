namespace CrownHotelListing.Core.DTOs
{
    public class HotelResponseDto : HotelRequestDto
    {
        public int Id { get; set; }
        public CountryRequestDto Country { get; set; }
    }
}
