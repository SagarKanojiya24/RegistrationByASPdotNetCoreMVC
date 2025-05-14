using Microsoft.EntityFrameworkCore;
using RegistrationByASPdotNetCoreMVC.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// this is by sagar for dependency purpose
builder.Services.AddScoped<RegistrationDbConnect>();


// this is by sagar for database connection purpose
// Configure the ApplicationDbContextJi to use SQL Server with the connection string from appsettings.json
builder.Services.AddDbContext<RegistrationDbConnect>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



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

app.Run();
