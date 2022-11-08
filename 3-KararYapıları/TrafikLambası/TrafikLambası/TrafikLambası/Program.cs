// See https://aka.ms/new-console-template for more information

Basla();

void Basla()
{
    Console.WriteLine("Trafik lambası hangi renk?");
    string? renk = Console.ReadLine();

    if (renk == "kırmızı")
    {
        Console.WriteLine("Dur!");
    }
    else if (renk == "sarı")
    {
        Console.WriteLine("Hazır ol!");
    }
    else if (renk == "yeşil")
    {
        Console.WriteLine("Geç!");
    }
    else
    {
        Console.WriteLine("Yanlış renk girdiniz!");
    }
    Console.ReadLine();
    Basla();
}


