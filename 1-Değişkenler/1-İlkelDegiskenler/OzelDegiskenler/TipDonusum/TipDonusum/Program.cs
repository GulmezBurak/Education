// See https://aka.ms/new-console-template for more information
object onRenk = ConsoleColor.White;
ConsoleColor arkaRenk = ConsoleColor.Red;
Console.BackgroundColor = arkaRenk;
Console.ForegroundColor = (ConsoleColor)onRenk;
// casting

object x = 100;
x = Convert.ToInt32(x) + 150;
object y = 100.25M;
object deger = true;
object ad = "Esra";
decimal a = 1.25M;
int b = 55;
int toplam = Convert.ToInt32(a) + b;
string adi = "Esra";
string soyadi = "Çetin";
int Tcno= 12121;
// string fullname = Tcno + " " + adi + " " + soyadi;
string fullname = $"{Tcno} {adi}-{soyadi} aaaa";
Console.WriteLine(fullname);


Console.WriteLine("int" + x);
Console.WriteLine("decimal" + y);
Console.WriteLine("bool" + deger);
Console.WriteLine("dizin" + ad);
