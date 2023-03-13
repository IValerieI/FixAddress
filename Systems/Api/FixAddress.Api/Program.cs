using FixAddress.Api;
using FixAddress.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.AddAppLogger();

// Add services to the container.

var services = builder.Services;

// ����� ��� ����������� CORS � ��� ���������� �����������
services.AddAppCors();

services.AddControllers();

// ����� ��� ����������� AutoMapper � ��� ���������� �����������
services.AddAppAutoMapper();

// ����� ��� ����������� ��������
services.RegisterAppServices();

// ��� ������������� IHttpClientFactory � �������
services.AddHttpClient();


var app = builder.Build();

app.UseAppCors();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
