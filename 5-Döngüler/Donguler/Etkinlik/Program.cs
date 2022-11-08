// See https://aka.ms/new-console-template for more information

int[] sayilar = { 23, 6, 29, 41, 87, 21 };

for (int i = sayilar.Length - 1; i >= 0; i--)
{
    Console.WriteLine(sayilar[i]);
}

Console.WriteLine("******************");

for (int i = 0; i < sayilar.Length; i += 2)
{
    Console.WriteLine(sayilar[i]);
}