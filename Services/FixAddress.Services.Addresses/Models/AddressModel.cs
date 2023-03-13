using AutoMapper;
using Dadata.Model;

namespace FixAddress.Services.Addresses;


/// <summary>
/// Модель для маппинга ответа от dadata
/// </summary>
public class AddressModel
{
    public string Address { get; set; }
    public string Postcode { get; set; }
    public string District { get; set; }
    public string Country { get; set; }
    public string Timezone { get; set; }


}

public class AddressModelProfile : Profile
{
    public AddressModelProfile()
    {
        CreateMap<Address, AddressModel>()
            .ForMember(m => m.Address, opt => opt.MapFrom(a => a.result))
            .ForMember(m => m.Country, opt => opt.MapFrom(a => a.country))
            .ForMember(m => m.Postcode, opt => opt.MapFrom(a => a.postal_code))
            .ForMember(m => m.Timezone, opt => opt.MapFrom(a => a.timezone))
            .ForMember(m => m.District, opt => opt.MapFrom(a => a.city_district));
    }
}
