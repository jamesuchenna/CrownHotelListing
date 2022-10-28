using System;
using System.ComponentModel.DataAnnotations;

namespace CrownHotelListing.Core.DTOs
{
    public class HotelRequestDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel Address is too long")]
        public string Address { get; set; }
        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }
        public int CountryId { get; set; }
    }
}
