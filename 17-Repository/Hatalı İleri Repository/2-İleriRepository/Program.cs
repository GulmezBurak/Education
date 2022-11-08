using _2_ÝleriRepository.Context;
using _2_ÝleriRepository.Data;
using _2_ÝleriRepository.Repositories.Abstract;
using _2_ÝleriRepository.Repositories.Concrete;
using _2_ÝleriRepository.UnitofWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IPersonnalRep, PersonnalRep<Personnal>>();//Herhangibir Controllerda IPersonnalRep gördüðü yerde PersonnalRepi new ler //bunun adý Dependency of Injection of version.
builder.Services.AddScoped<ICityRep, CityRep<City>>();
builder.Services.AddScoped<ICountyRep, CountyRep<County>>();
builder.Services.AddScoped<IDepartmentRep, DepartmentRep<Department>>();
builder.Services.AddScoped<IGradeRep, GradeRep<Grade>>();
builder.Services.AddScoped<IUnit, Unit>();

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
