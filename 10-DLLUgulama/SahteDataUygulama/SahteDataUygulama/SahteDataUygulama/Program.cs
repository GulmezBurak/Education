

using SahteData;
using SahteDataUygulama;
using System.Collections;
using System.Collections.Generic;


List<Ogrenci> olist = new List<Ogrenci>();
for (int i = 1; i < 21; i++)
{
    Ogrenci o = new Ogrenci();
    o.Id = i;
    o.Ad = SahteData.NameData.GetFirstName();
    o.Soyad = SahteData.NameData.GetSurName();
    o.Sehir = SahteData.PlaceData.GetCity();
    o.Ilce = SahteData.PlaceData.GetCounty();
    o.Sokak = SahteData.PlaceData.GetStreetName();
    olist.Add(o);
}
foreach (var item in olist)
{
    Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad} {item.Sehir} {item.Ilce} {item.Sokak}");
}







