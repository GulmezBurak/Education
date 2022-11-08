// See https://aka.ms/new-console-template for more information

using basitKatilim;

Egitmen e = new Egitmen();
e.Ad = "Şamil";
e.Soyad = "Yılmaz";
e.Unvan = "Yazılım Uzmanı";
e.Maas = 7000;
e.Cinsiyet = 'E';
e.Cadde = "Bahariye Cad.";
e.Sokak = "Manolya sokak";
e.KapiNo = 12;
e.Ilce = "Kadıköy";
e.Sehir = "İstanbul";
var Date = new DateTime(1960, 12, 12);
e.DogumTarihi = Date;
Console.WriteLine(e.YasHesapla());
Console.WriteLine(e.MaasHesapla());

Ogrenci o = new Ogrenci();
o.Vize = 10;
o.Final = 100;
Console.WriteLine(o.NotHesapla());




