// See https://aka.ms/new-console-template for more information
Basla();
void Basla()
{
    try
    {
        Console.WriteLine("Kaç TL var?");
        decimal tlTut = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Kaç Dolar var?");
        decimal dolTut = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Kaç Euro var?");
        decimal euroTut = Convert.ToDecimal(Console.ReadLine());
        dolTut = KurHesapla(dolTut);
        euroTut = KurHesapla2(euroTut);
        decimal toplam = dolTut + euroTut + tlTut;
        Console.WriteLine("Toplam Paran : " + toplam);
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayısal değer giriniz.");
        Basla();
    }
    
}


decimal KurHesapla(decimal dolTut)
{
    decimal kur = 0;
    try
    {
        Console.WriteLine("Dolar Kuru ?");
        kur = Convert.ToDecimal(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayısal değer giriniz.");
        Basla();
    }
    dolTut *= kur;
    return dolTut;
}

decimal KurHesapla2(decimal euroTut)
{
    decimal kur = 0;
    try
    {
        Console.WriteLine("Euro Kuru ?");
        kur = Convert.ToDecimal(Console.ReadLine()); 
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayısal değer giriniz.");
        Basla();
    }
    euroTut *= kur;
    return euroTut;
}
