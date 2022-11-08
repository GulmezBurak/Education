using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nedenOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] isimler = { "Ali", "Veli", "Ayşe" };
            int[] Idler = { 10, 20, 30 };
            Console.WriteLine("Id giriniz");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == 10)
            {
                Console.WriteLine("İsmi: " + "Ali");
            }
            else if (id == 20)
            {
                Console.WriteLine("İsmi: " + "Veli");
            }
            else if (id == 30)
            {
                Console.WriteLine("İsmi: " + "Ayşe");
            }
            else
            {
                Console.WriteLine("Yanlış Id");
            }
            Console.ReadLine();*/

            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Esra";
            o1.Soyad = "Çetin";
            o1.Sehir = "İstanbul";
            o1.Cadde = "Çiğdem";
            o1.Id = 1;
            o1.Ilce = "Küçükçekmece";
            o1.Kapino = 9;
            o1.Cinsiyet = "K";

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Burak";
            o2.Soyad = "Gülmez";
            o2.Sehir = "İstanbul";
            o2.Cadde = "9. Kısım";
            o2.Id = 2;
            o2.Ilce = "Bakırköy";
            o2.Kapino = 73;
            o2.Cinsiyet = "E";

            Ogrenci[] ogrenciler = { o1, o2 };

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Unvan());
            }
            Console.ReadLine();

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i].Unvan());
            }
            Console.ReadLine();
             
        }
    }
}
