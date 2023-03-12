using FixAddress.Api.Controllers.Models;
using FixAddress.Services.Addresses;

namespace FixAddress.Api.Configuration;

public static class AutoMapperConfiguration
{
    /// <summary>
    /// Добавляет AutoMapper (с Profiles, по которым будет маппинг)
    /// </summary>
    /// <param name="services"></param>
    public static void AddAppAutoMapper(this IServiceCollection services)
    {
        // Подключаю AutoMapper, передаю Profiles, по которым будет маппинг
        services.AddAutoMapper(typeof(AddressModelProfile), typeof(AddressResponseProfile));

    }
}
