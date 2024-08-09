using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetShopWithMSIdentity.Areas.Identity.Data;
using PetShopWithMSIdentity.Data;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PetShopWithMSIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'PetShopWithMSIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<PetShopWithMSIdentityDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<PetShopWithMSIdentityDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();
builder.Services.AddDbContext<PetDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PetDataContext") ?? throw new InvalidOperationException("Connection string 'PetDataContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
