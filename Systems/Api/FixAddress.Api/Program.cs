using FixAddress.Api;
using FixAddress.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

// ����� ��� ����������� CORS � ��� ���������� �����������
services.AddAppCors();

services.AddControllers();

// ����� ��� ����������� AutoMapper � ��� ���������� �����������
services.AddAppAutoMapper();

services.RegisterAppServices();

var app = builder.Build();

app.UseAppCors();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
