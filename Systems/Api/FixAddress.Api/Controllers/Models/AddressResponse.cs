using AutoMapper;
using FixAddress.Services.Addresses;

namespace FixAddress.Api.Controllers.Models;

/// <summary>
/// Модель для отправки пользователю
/// </summary>
public class AddressResponse
{
    public string Address { get; set; }
    public string Postcode { get; set; }
}

public class AddressResponseProfile : Profile
{
    public AddressResponseProfile()
    {
        CreateMap<AddressModel, AddressResponse>()
            .ForMember(r => r.Address, opt => opt.MapFrom(a => a.Address))
            .ForMember(r => r.Postcode, opt => opt.MapFrom(a => a.Postcode));
    }
}
