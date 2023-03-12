using Microsoft.Extensions.DependencyInjection;

namespace FixAddress.Services.Addresses;


public static class Bootstrapper
{
    /// <summary>
    /// Добавляет AddressService в DI контейнер
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddAddressService(this IServiceCollection services)
    {
        services.AddSingleton<IAddressService, AddressService>();
        return services;
    }

}
