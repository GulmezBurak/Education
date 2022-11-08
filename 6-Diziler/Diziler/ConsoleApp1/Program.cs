// See https://aka.ms/new-console-template for more information

using System.Collections;
ArrayList meyveler = new ArrayList();
do
{
    Console.WriteLine("Meyve Adı");
    meyveler.Add(Console.ReadLine());
    Goster();
} while (true);


void Goster()
{
    foreach (var item in meyveler)
    {
        Console.WriteLine(item);
    }
}