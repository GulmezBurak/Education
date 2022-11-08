// See https://aka.ms/new-console-template for more information

using basitKatilim;

Ogrenci o = new Ogrenci();
o.Ad = "Esra";
o.Soyad = "Çetin";
o.Sehir = "İstanbul";
o.Ilce = "Küçükçekmece";
o.Sokak = "Çiğdem sokak";
o.Cadde = "Cumhuriyet Cad";

Console.WriteLine(o.FullName());
foreach (var item in o.AdresAl())
{
    Console.WriteLine(item);
}


