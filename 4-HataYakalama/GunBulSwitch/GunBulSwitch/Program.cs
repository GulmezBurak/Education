// See https://aka.ms/new-console-template for more information
Basla();

void Basla()
{
    try
    {
        Console.WriteLine("Kaçıncı gündeyiz?");
        int gun = Convert.ToInt32(Console.ReadLine());
        switch (gun)
        {
            case 1:
                Console.WriteLine("Bugün Pazartesi");
                break;
            case 2:
                Console.WriteLine("Bugün Salı");
                break;
            case 3:
                Console.WriteLine("Bugün Çarşamba");
                break;
            case 4:
                Console.WriteLine("Bugün Perşembe");
                break;
            case 5:
                Console.WriteLine("Bugün Cuma");
                break;
            case 6:
                Console.WriteLine("Bugün Cumartesi");
                break;
            case 7:
                Console.WriteLine("Bugün Pazar");
                break;
            default:
                Console.WriteLine("Yanlış sayı girdiniz!");
                break;
        }
        Console.ReadLine();
        Basla();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Basla();
    }
    
}