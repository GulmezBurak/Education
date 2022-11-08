// See https://aka.ms/new-console-template for more information
Basla();
void Basla()
{
    decimal tlTut = Cevir("Kaç TL var?");
    decimal dolTut = Cevir("Kaç Dolar var?");
    decimal euroTut = Cevir("Kaç Euro var?");
    dolTut = KurHesapla(dolTut,"Dolar Kuru?");
    euroTut = KurHesapla(euroTut, "Euro Kur?");
    decimal toplam = dolTut + euroTut + tlTut;
    Console.WriteLine("Toplam Paran : " + toplam);
}


decimal KurHesapla(decimal yp,string soru)
{
    return Cevir(soru)*yp;
    //return yp *= kur;
    //return yp;
}
decimal Cevir(string soru)
{
    try
    {
        Console.WriteLine(soru);
        return Convert.ToDecimal(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Sayısal değer giriniz.");
        return 0;
        Cevir(soru);
    }
    

}

