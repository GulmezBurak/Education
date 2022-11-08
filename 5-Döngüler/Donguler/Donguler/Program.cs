// See https://aka.ms/new-console-template for more information

int[] sayilar = { 10, 15, 77, 42, 62, 10 };
int sayac = 0;
int toplam = 0;

// for döngüsü
Console.WriteLine("*****************");
Console.WriteLine("For Döngüsü");
Console.WriteLine("*****************");
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
    toplam += sayilar[i];
}
Console.WriteLine("_________________");
Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("_________________");

toplam = 0;
// do döngüsü
Console.WriteLine("*****************");
Console.WriteLine("Do Döngüsü");
Console.WriteLine("*****************");
do
{
    Console.WriteLine(sayilar[sayac]);
    toplam += sayilar[sayac];
    sayac++;
} while (sayac<sayilar.Length);
Console.WriteLine("_________________");
Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("_________________");

toplam = 0;
sayac = 0;
// while döngüsü
Console.WriteLine("*****************");
Console.WriteLine("While Döngüsü");
Console.WriteLine("*****************");
while (sayac<sayilar.Length)
{
    Console.WriteLine(sayilar[sayac]);
    toplam += sayilar[sayac];
    sayac++;
}
Console.WriteLine("_________________");
Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("_________________");

toplam = 0;
// foreach döngüsü
Console.WriteLine("*****************");
Console.WriteLine("Foreach Döngüsü");
Console.WriteLine("*****************");
foreach (var item in sayilar)
{
    Console.WriteLine(item);
    toplam += item;
}
Console.WriteLine("_________________");
Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("_________________");
