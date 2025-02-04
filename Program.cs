using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CMS_API.Data;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CMS_APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CMS_APIContext") ?? throw new InvalidOperationException("Connection string 'CMS_APIContext' not found.")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
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