// See https://aka.ms/new-console-template for more information


int[] sayilar = { 10, 15, 77, 42, 62, 10 };
int sayac = 0;
int toplam = 0;
Basla();
void Basla()
{
    ForDongusu();
    DoDongusu();
    WhileDongusu();
    ForeachDongusu();
}


void ForDongusu()
{
    BaslikYaz("For Döngüsü");
    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.WriteLine(sayilar[i]);
        toplam += sayilar[i];
    }
    ToplamYaz();
}

void DoDongusu()
{
    toplam = 0;
    BaslikYaz("Do Döngüsü");
    do
    {
        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;
    } while (sayac < sayilar.Length);
    ToplamYaz();
}

void WhileDongusu()
{
    toplam = 0;
    sayac = 0;
    BaslikYaz("While Döngüsü");
    while (sayac < sayilar.Length)
    {
        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;
    }
    ToplamYaz();
}

void ForeachDongusu()
{
    toplam = 0;
    BaslikYaz("Foreach Döngüsü");
    foreach (var item in sayilar)
    {
        Console.WriteLine(item);
        toplam += item;
    }
    ToplamYaz();
}

void BaslikYaz(string metin)
{
    Console.WriteLine("*****************");
    Console.WriteLine(metin);
    Console.WriteLine("*****************");
}

void ToplamYaz()
{
    Console.WriteLine("-----------------");
    Console.WriteLine("Toplam : " + toplam);
    Console.WriteLine("-----------------");
}
