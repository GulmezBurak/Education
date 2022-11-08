// See https://aka.ms/new-console-template for more information

Basla();

void Basla()
{
    int x = 100;
    Console.WriteLine("x in ilk değeri " + x );
    double y = Karekok(x);
    Console.WriteLine("x in geri dönüş değeri " + y);
}

double Karekok(int x)
{
    return Math.Sqrt(Convert.ToDouble(x));
}