using KatmanliMimari.Dl;
using KatmanliMimari.Ent;
using KatmanliMimari.Rep.Abstract;
using KatmanliMimari.Rep.Concrete;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IPersonnalRep, PersonnalRep<Personnal>>();
builder.Services.AddScoped<IUnit, Unit>();
builder.Services.AddScoped<PersonnalModel>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
