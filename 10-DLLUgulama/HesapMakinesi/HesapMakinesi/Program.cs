// See https://aka.ms/new-console-template for more information

using Hesaplama;

//Islem isl = new Islem();
Basla();

void Basla()
{
    decimal x = Cevir("1. Sayı");
    decimal y = Cevir("2. Sayı");
    decimal sonuc = Islem(x, y);
    Console.WriteLine("Sonuç : " + sonuc);

}


decimal Islem(decimal x, decimal y)
{
    decimal sonuc = 0;
    Console.WriteLine("İşlem Kodu ?");
    string iskod = Console.ReadLine();
    if (iskod == "+")
    {
        sonuc = Hesaplama.Islem.Topla(x, y);
    }
    else if (iskod == "-")
    {
        sonuc = Hesaplama.Islem.Cikar(x, y);
    }
    else if (iskod == "*")
    {
        sonuc = Hesaplama.Islem.Carp(x, y);
    }
    else if (iskod == "/")
    {
        sonuc = Hesaplama.Islem.Bol(x, y);
    }
    else
    {
        Console.WriteLine("Yanlış Kod");
        return Islem(x, y);
    }
    return sonuc;
}

decimal Cevir(string txt)
{
    Console.WriteLine(txt);
    return Convert.ToDecimal(Console.ReadLine());
}