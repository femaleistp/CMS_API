using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CMS_API.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CMS_API.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Link up the database
builder.Services.AddDbContext<CMS_APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CMS_APIContext") ??
    throw new InvalidOperationException("Connection string 'CMS_APIContext' not found.")));

// Link Identity Framework to the database
builder.Services.AddDefaultIdentity<BlogUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<CMS_APIContext>();

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();