using SmartSales.Application;
using SmartSales.Domain.Interfaces;
using SmartSales.Infrastructure;
using SmartSales.Infrastructure.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDependecyInjection();
builder.Services.AddInfrastructureServices(builder.Configuration);


builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
