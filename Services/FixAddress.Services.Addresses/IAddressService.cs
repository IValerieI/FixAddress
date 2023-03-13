namespace FixAddress.Services.Addresses;

public interface IAddressService
{
    Task<AddressModel> GetAddress(string brokenAddress);
    Task<string> GetAddressDetail(string brokenAddress);
}
