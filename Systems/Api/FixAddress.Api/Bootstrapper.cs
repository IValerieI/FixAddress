using FixAddress.Services.Addresses;

namespace FixAddress.Api;

public static class Bootstrapper
{
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services.AddAddressService();
        return services;
    }

}
