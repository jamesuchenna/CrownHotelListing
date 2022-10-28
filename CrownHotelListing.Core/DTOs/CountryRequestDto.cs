using System.ComponentModel.DataAnnotations;

namespace CrownHotelListing.Core.DTOs
{
    public class CountryRequestDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country name is too long")]
        public string ShortName { get; set; }
    }
}
