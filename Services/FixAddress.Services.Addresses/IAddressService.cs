namespace FixAddress.Services.Addresses;

public interface IAddressService
{
    Task<AddressModel> GetAddress(string brokenAddress);
}
