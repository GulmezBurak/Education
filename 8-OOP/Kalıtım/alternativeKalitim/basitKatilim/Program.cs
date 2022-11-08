// See https://aka.ms/new-console-template for more information

using basitKatilim;

Ogrenci o = new Ogrenci();
o.Ad = "Esra";
o.Soyad = "Çetin";
//o.Adres = new Adres();
o.Adres.Sehir = "İstanbul";
o.Adres.Ilce = "Küçükçekmece";
o.Adres.Sokak = "Çiğdem sokak";
o.Adres.Cadde = "Cumhuriyet Cad";

Console.WriteLine(o.FullName());
foreach (var item in o.AdresAl())
{
    Console.WriteLine(item);
}


