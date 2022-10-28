using AutoMapper;
using CrownHotelListing.Core.DTOs;
using CrownHotelListing.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Core.AutoMapperProfiles
{
    public class AutoMapperInitializer : Profile
    {
        public AutoMapperInitializer()
        {
            CreateMap<Country, CountryRequestDto>().ReverseMap();
            CreateMap<Country, CountryResponseDto>().ReverseMap();
            CreateMap<Hotel, HotelRequestDto>().ReverseMap();
            CreateMap<Hotel, HotelResponseDto>().ReverseMap();
        }
    }
}
