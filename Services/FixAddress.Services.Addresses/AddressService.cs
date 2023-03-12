using AutoMapper;
using Dadata;
using Dadata.Model;

namespace FixAddress.Services.Addresses;


public class AddressService : IAddressService
{
    private readonly IMapper mapper;

    public AddressService(IMapper mapper)
    {
        this.mapper = mapper;
    }


    public async Task<AddressModel> GetAddress(string brokenAddress)
    {
        // move token and secret to settings
        var token = "f68cfa2adabf0f766554018492e3076488c8931c";
        var secret = "4f29142cef836bbeeebfbde9fe65221c6850a067";

        var api = new CleanClientAsync(token, secret);
        var address = await api.Clean<Address>(brokenAddress);

        var data = mapper.Map<AddressModel>(address);

        return data;
    }
}
