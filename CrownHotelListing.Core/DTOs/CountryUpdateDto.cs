﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Core.DTOs
{
    public class CountryUpdateDto : CountryRequestDto
    {
        public IList<HotelUpdateDto> Hotels { get; set; }
    }
}
