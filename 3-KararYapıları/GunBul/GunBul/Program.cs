// See https://aka.ms/new-console-template for more information

Basla();

void Basla()
{
    string metin = "";
    Console.WriteLine("Kaçıncı Gündeyiz");
    int gun = Convert.ToInt32(Console.ReadLine());
    if (gun == 1)
    {
        metin = "Pazartesi";
    }
    else if (gun == 2)
    {
        metin = "Salı";
    }
    else if (gun == 3)
    {
        metin = "Çarşamba";
    }
    else if (gun == 4)
    {
        metin = "Perşembe";
    }
    else if (gun == 5)
    {
        metin = "Cuma";
    }
    else if (gun == 6)
    {
        metin = "Cumartesi";
    }
    else if (gun == 7)
    {
        metin = "Pazar";
    }
    else
    {
        metin = "Yanlış sayı girdiniz";
    }
    Console.WriteLine(metin);
    Console.ReadLine();
    Basla();
    // Recursive call method
}


