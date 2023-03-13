using FixAddress.Api;
using FixAddress.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.AddAppLogger();

// Add services to the container.

var services = builder.Services;

// Метод для подключения CORS с уже указанными настройками
services.AddAppCors();

services.AddControllers();

// Метод для подключения AutoMapper с уже указанными настройками
services.AddAppAutoMapper();

// Метод для подключения сервисов
services.RegisterAppServices();

// Для использования IHttpClientFactory в сервисе
services.AddHttpClient();


var app = builder.Build();

app.UseAppCors();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
