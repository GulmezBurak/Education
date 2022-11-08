using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 35, 14, 7 };
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            ArrayList sayilar2 = new ArrayList();
            //Console.WriteLine("Sayı ?");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            sayilar2.Add(5);
            sayilar2.Add(6);
            sayilar2.Add(75);
            sayilar2.Remove(75);
            sayilar2.RemoveAt(0); //0. indexi siler yani 5 i
            sayilar2.Add("Elma");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            List<int> sayilar3 = new List<int>();
            sayilar3.Add(5);
            sayilar3.Add(100);
            sayilar3.Add(202);
            sayilar3.Remove(5);
            foreach (var item in sayilar3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            List<string> meyveler = new List<string>();
            meyveler.Add("Elma");
            meyveler.Add("Armut");
            meyveler.Add("Muz");
            foreach (var item in meyveler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            List<object> karisik = new List<object>();
            karisik.Add("Elma");
            karisik.Add("Armut");
            karisik.Add(54);
            karisik.Add(105);
            karisik.Add("Muz");
            foreach (var item in karisik)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            List<Personel> pList = new List<Personel>();
            Personel p1 = new Personel();
            p1.Ad = "Esra";
            p1.Soyad = "Çetin";
            pList.Add(p1);

            Personel p2 = new Personel();
            p2.Ad = "Burak";
            p2.Soyad = "Gülmez";
            pList.Add(p2);

            foreach (var item in pList)
            {
                Console.WriteLine(item.Ad+" "+item.Soyad);
            }
            //var liste = select * from personel




            Console.ReadLine();
        }
    }
}
