using AutoMapper;
using Hotel_Listing.DataEntity;
using Hotel_Listing.DTO;

namespace Hotel_Listing.Configuration
{
    public class MapperIntializer:Profile
    {
        public MapperIntializer()
        {
            CreateMap<Country,CountryDTO>().ReverseMap();
            CreateMap<Country,CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel,HotelDTO>().ReverseMap();
            CreateMap<Hotel,CreateHotelDTO>().ReverseMap();

        }
    }
}
