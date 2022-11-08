using PersonelProje.Data;
using PersonelProje.Models;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*builder.Services.AddScoped<Ulke>();*/ //new lememek için bunu ekliyoruz. metod içinde newleniyo sonra kapanýyor.
builder.Services.AddSingleton<SqlConnection>(); //scopeta süslü parantezden çýktýktan sonra kapsama almýyor. bu ise sürekli çalýþýyor. bir kere newlendi mi hep hafýzada kalýyor.
builder.Services.AddScoped<PersonelModel>();

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
