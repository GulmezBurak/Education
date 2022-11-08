// See https://aka.ms/new-console-template for more information

Basla();

static void Basla()
{
    Console.WriteLine("Kaç TL'n var?");
    decimal tlTut = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Kaç Dolar'ın var?");
    decimal dolarTut = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Kaç Euro'n var?");
    decimal euroTut = Convert.ToDecimal(Console.ReadLine());
    Yazdır(tlTut,dolarTut,euroTut);
}
static void Yazdır(decimal tl,decimal dol,decimal eur)
{
    Console.WriteLine("Dolar Kuru ?");
    decimal dolarKur = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Euro Kuru ?");
    decimal euroKur = Convert.ToDecimal(Console.ReadLine());
    dol = dolarKur * dol;
    eur = euroKur * eur;
    decimal toplam = tl + dol + eur;
    Console.WriteLine("Toplam Para: "+toplam);
}