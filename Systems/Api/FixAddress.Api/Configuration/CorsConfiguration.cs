namespace FixAddress.Api.Configuration;

public static class CorsConfiguration
{
    /// <summary>
    /// Настраивает политику CORS
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddAppCors(this IServiceCollection services)
    {
        services.AddCors(builder =>
        {
            builder.AddDefaultPolicy(pol =>
            {
                pol.WithOrigins("https://cleaner.dadata.ru");
                pol.WithMethods("POST");
            });
        });
        return services;
    }

    public static void UseAppCors(this IApplicationBuilder app)
    {
        app.UseCors();
    }


}
