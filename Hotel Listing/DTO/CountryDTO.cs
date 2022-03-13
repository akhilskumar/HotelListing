using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Listing.DTO
{
    public class CountryDTO:CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name exceeds 50 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Name exceeds 3 characters")]
        public string ShortName { get; set; }
    }
}
