namespace FixAddress.Services.Addresses;


public class AddressService : IAddressService
{
    public async Task<AddressModel> GetAddress(string brokenAddress)
    {
        var token = "f68cfa2adabf0f766554018492e3076488c8931c";
        var secret = "4f29142cef836bbeeebfbde9fe65221c6850a067";

        var api = new CleanClientAsync(token, secret);
        var result = await api.Clean<Address>(oldAddress);



        return result;
    }
}
