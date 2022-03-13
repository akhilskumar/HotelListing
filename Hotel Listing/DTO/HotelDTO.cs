using System.ComponentModel.DataAnnotations;

namespace Hotel_Listing.DTO
{

    public class CreateHotelDTO
    {
       
        [Required]
        [StringLength(maximumLength: 50,ErrorMessage ="Country name exceeds 50 charcter")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Address name exceeds 50 charcter")]
        public string Address { get; set; }
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }

    }
    public class HotelDTO:CreateHotelDTO
    {
        public int id { get; set; }
        public CountryDTO countryDTO { get; set; }
    }
}
