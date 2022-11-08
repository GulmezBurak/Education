// See https://aka.ms/new-console-template for more information

using System.Collections;

int[] sayilar = { 10, 20, 30, 25 };

Console.WriteLine(sayilar[0]);
sayilar[0] = 100;
Console.WriteLine(sayilar[0]);
Array.Sort(sayilar);
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

Console.WriteLine(sayilar.Max());
Console.WriteLine(sayilar.Min());
Console.WriteLine(sayilar.Sum());

Console.WriteLine("*******************");
