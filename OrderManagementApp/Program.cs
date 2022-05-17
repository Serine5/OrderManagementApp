using ApplicationLayer.IServices;
using ApplicationLayer.Services;
using DAL.Context;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IDropdownService, DropDownService>();
var configuration = new ConfigurationBuilder()
   .AddEnvironmentVariables()
   .AddCommandLine(args)
   .AddJsonFile("appsettings.json")
   .AddUserSecrets<Program>(true)
   .Build();
//builder.Configuration
//   .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("secrets.json");

builder.Services.AddDbContext<OrderManagementContext>(options => options.
       UseSqlServer(builder.Configuration.GetConnectionString("myConxStr")));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
