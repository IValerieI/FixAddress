using FixAddress.Api;
using FixAddress.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

// Метод для подключения CORS с уже указанными настройками
services.AddAppCors();

services.AddControllers();

// Метод для подключения AutoMapper с уже указанными настройками
services.AddAppAutoMapper();

services.RegisterAppServices();

var app = builder.Build();

app.UseAppCors();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
