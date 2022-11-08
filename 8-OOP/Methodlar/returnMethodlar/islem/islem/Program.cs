// See https://aka.ms/new-console-template for more information

Basla();
void Basla()
{
    decimal birinci = Cevir("Birinci sayı?");
    decimal ikinci = Cevir("İkinci sayı?");
    decimal sonuc = Islem(birinci,ikinci);
    Console.WriteLine("İşlem sonucu : "+sonuc);
    Console.ReadKey();
}
decimal Islem(decimal birinci,decimal ikinci)
{
    decimal sonuc = 0;
    string isKod = IslemAl();
    switch (isKod)
    {
        case "+":
            sonuc = birinci + ikinci;
            break;
        case "-":
            sonuc = birinci - ikinci;
            break;
        case "*":
            sonuc = birinci * ikinci;
            break;
        case "/":
            sonuc = birinci / ikinci;
            break;
        default:
            Console.WriteLine("Yanlış işlem kod.");
            Islem(birinci, ikinci);
            break;
    }
    return sonuc;
}
string IslemAl()
{
    Console.WriteLine("İşlem kodu?");
    return Console.ReadLine();
}

decimal Cevir(string soru)
{
    Console.WriteLine(soru);
    return Convert.ToDecimal(Console.ReadLine());
}

