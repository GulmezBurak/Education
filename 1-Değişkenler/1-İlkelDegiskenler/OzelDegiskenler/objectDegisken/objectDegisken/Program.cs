// See https://aka.ms/new-console-template for more information
object onRenk = ConsoleColor.White;
ConsoleColor arkaRenk = ConsoleColor.Red;
Console.BackgroundColor = arkaRenk;
Console.ForegroundColor = (ConsoleColor) onRenk;
// casting

object x = 100;
x = Convert.ToInt32(x) + 150;
object y = 100.25M;
object deger = true;
object ad = "Esra";
Console.WriteLine("int" + x);
Console.WriteLine("decimal" + y);
Console.WriteLine("bool" + deger);
Console.WriteLine("dizin" + ad);
