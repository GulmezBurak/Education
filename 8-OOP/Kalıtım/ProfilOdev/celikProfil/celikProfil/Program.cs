// See https://aka.ms/new-console-template for more information

using celikProfil;

TemelUrun tu = new TemelUrun();
tu.Yukseklik = 5;
Console.WriteLine("Hacim: " + tu.Hacim() +" " + "Fire: " + tu.Fire());

DikdörtgenProfil dp = new DikdörtgenProfil();
dp.Yukseklik = 2;
dp.KisaKenar = 10;
dp.UzunKenar = 10;
Console.WriteLine("Hacim: " + dp.Hacim() + " " + "Fire: " + dp.Fire());
