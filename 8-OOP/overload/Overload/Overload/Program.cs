// See https://aka.ms/new-console-template for more information

using Overload;
//Statik olmayan için = Dinamik
//Hesaplama hes = new Hesaplama();
//int[] sayilar = { 10, 20, 30, 100 };
//int x = hes.Topla(sayilar);
//Console.WriteLine(x);

//---------------------------------------

//Static
int[] sayilar = { 10, 20, 30, 100 };
int x = Hesaplama.Topla(sayilar);
Console.WriteLine(x);

Console.WriteLine(Math.Sin(Math.PI/6));
Math.Sqrt(Math.PI/6);

// Aynı isimdeki metodu birden fazla parametreyle yazmaya OVERLOAD deniyor.