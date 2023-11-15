using Manero.Helpers.Repositories;
using Manero.Helpers.Services;
using Manero.Models.Contexts;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string projectFilePath = Environment.CurrentDirectory;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(x =>
x.UseSqlServer(
    builder.Configuration.GetConnectionString("DynamicPartOne") +
    projectFilePath +
    builder.Configuration.GetConnectionString("DynamicPartTwo")));


builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<Manero.Models.ViewModels.Cart>();


builder.Services.AddScoped<InterfaceAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<InterfaceEdietProfileService, EditProfileService>();
builder.Services.AddIdentity<ManeroUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<DataContext>()
.AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();


var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Onboarding}/{action=Index}/{id?}");

app.Run();