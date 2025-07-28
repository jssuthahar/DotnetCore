using Microsoft.EntityFrameworkCore;
using MiniSuperMarket;
using MiniSuperMarket.Data;
using MiniSuperMarket.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICalc, Calc>(); // every time a new instance is created
//builder.Services.AddScoped<ICalc, Calc>();// instance is created per request
//builder.Services.AddSingleton<ICalc, Calc>();// single instance for the lifetime of the application
var connect = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(connect));
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
