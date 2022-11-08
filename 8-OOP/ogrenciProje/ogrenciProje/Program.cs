using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciProje
{
    internal class Program
    {
        static List<Ogrenci> olist = new List<Ogrenci>();
        static void Main()
        {
            Console.Clear();
            Menu();
        }
        static void Menu() 
        {
            Console.WriteLine("1-Liste Oluştur");
            Console.WriteLine("2-Liste Görüntüle");
            Console.WriteLine("3-Personel Sil");
            Console.WriteLine("4-Personel Güncelle");
            Console.WriteLine("5-Personel Ekle");
            Console.WriteLine("6-Personel Detay");

            string secim = Console.ReadLine();
            if (secim == "1")
            {
                CreateList();
                Console.ReadLine();
                Menu();
            }
            else if (secim == "2")
            {
                PrintList(olist);
                Console.ReadLine();
                Menu();
            }
            else if (secim == "3")
            {
                DeletePersonel();
                Console.ReadLine();
                Menu();
            }
            else if (secim == "4")
            {
                UpdatePersonel();
                Console.ReadLine();
                Menu();
            }
            else if (secim == "5")
            {
                AddPersonel();
                Console.ReadLine();
                Menu();
            }
            else if (secim == "6")
            {
                DetailPersonel();
                Console.ReadLine();
                Menu();
            }
        }
        static void DetailPersonel()
        {
            Console.WriteLine("Id ?");
            int Id = Convert.ToInt32(Console.ReadLine());
            Ogrenci secilenOgrenci = olist.Where(o => o.Id == Id).FirstOrDefault();
            Console.WriteLine("Personel Detay");
            Console.WriteLine("**************");
            Console.WriteLine(secilenOgrenci.Unvan() + " " + secilenOgrenci.Yas());
            Console.WriteLine("Adres:");
            Console.WriteLine("------");
            foreach (var item in secilenOgrenci.AdresAl())
            {
                Console.WriteLine(item);
            }

        }
        static void AddPersonel()
        {
            Ogrenci yogrenci = new Ogrenci();
            Console.WriteLine("Ad :");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad :");
            string soyad = Console.ReadLine();
            yogrenci.Ad = ad;
            yogrenci.Soyad = soyad;
            olist.Add(yogrenci);
            yogrenci.Id = olist.Max(o => o.Id) + 1;
            PrintList(olist);
        }
        static void UpdatePersonel()
        {
            Console.WriteLine("Id ?");
            int guncellenecekId = Convert.ToInt32(Console.ReadLine());
            Ogrenci guncelOgrenci = olist.Where(o => o.Id == guncellenecekId).FirstOrDefault();
            Console.WriteLine("Ad :");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad :");
            string soyad = Console.ReadLine();
            guncelOgrenci.Ad = ad;
            guncelOgrenci.Soyad = soyad;
            PrintList(olist);
        }
        static void DeletePersonel()
        {
            Console.WriteLine("Id ?");
            int silinecekId = Convert.ToInt32(Console.ReadLine());
            Ogrenci silinecekOgrenci = olist.Where(o => o.Id == silinecekId).FirstOrDefault();
            olist.Remove(silinecekOgrenci);
            PrintList(olist);

        }
        static void PrintList(List<Ogrenci> lst)
        {
            Console.WriteLine("Id   Ad  Soyad");
            foreach (var item in lst)
            {
                Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad}");
            }
            ToplamAl(lst);
        }
        static void ToplamAl(List<Ogrenci> lsttop)
        {
            //1. Yol
            //int toplamKisi = 0;
            //int toplamKadin = 0;
            //int toplamErkek = 0;
            //int toplamMaas = 0;
            //int toplamKadinMaas = 0;
            //int toplamErkekMaas = 0;
            //double ortMaas = 0;
            //double ortKadinMaas = 0;
            //double ortErkekMaas = 0;
            //foreach (var item in lsttop)
            //{
            //    toplamKisi++;
            //    toplamMaas += item.Maas;
            //    if (item.Cinsiyet == "E")
            //    {
            //        toplamErkekMaas += item.Maas;
            //        toplamErkek++;
            //    }
            //    else
            //    {
            //        toplamKadinMaas += item.Maas;
            //        toplamKadin++;
            //    }
            //}
            //ortErkekMaas = toplamErkekMaas / toplamErkek;
            //ortKadinMaas = toplamKadinMaas / toplamKadin;
            //ortMaas = toplamMaas / toplamKisi;

            // 2. Yol Lampda expression
            // Arka planda foreach döngüsü yapıyor
            int toplamKisi = lsttop.Count;
            int toplamMaas = lsttop.Sum(item => item.Maas);
            int toplamKadin = lsttop.Where(x => x.Cinsiyet == "K").Count();
            int toplamErkek = lsttop.Where(x => x.Cinsiyet == "E").Count();
            int toplamKadinMaas = lsttop.Where(x => x.Cinsiyet == "K").Sum(x => x.Maas);
            int toplamErkekMaas = lsttop.Where(x => x.Cinsiyet == "E").Sum(x => x.Maas);
            double ortMaas = lsttop.Average(x => x.Maas);
            double ortKadinMaas = lsttop.Where(x=> x.Cinsiyet == "K").Average(x=> x.Maas);
            double ortErkekMaas = lsttop.Where(x => x.Cinsiyet == "E").Average(x => x.Maas);

            Console.WriteLine("Toplamlar ");
            Console.WriteLine("------------");
            Console.WriteLine("Toplam Kişi " + toplamKisi);
            Console.WriteLine("Toplam Kadın " + toplamKadin);
            Console.WriteLine("Toplam Erkek " + toplamErkek);
            Console.WriteLine("Toplam Maas " + toplamMaas);
            Console.WriteLine("Toplam Kadın Maaş " + toplamKadinMaas);
            Console.WriteLine("Toplam Erkek Maaş " + toplamErkekMaas);
            Console.WriteLine("Ortalama Maaş " + ortMaas);
            Console.WriteLine("Ortalama Erkek Maaş " + ortErkekMaas);
            Console.WriteLine("Ortalama Kadın Maaş " + ortKadinMaas);
            Console.WriteLine("------------");

        }
        static void CreateList()
        {
            Random random = new Random();
            for (int i = 1; i < 21; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Maas = random.Next(4000,20000);
                o.Ad = FakeData.NameData.GetFirstName();
                o.Soyad = FakeData.NameData.GetSurname();
                o.Cadde = FakeData.PlaceData.GetStreetName();
                int cns = random.Next(0,2);
                if (cns == 0)
                {
                    o.Cinsiyet = "K";
                }
                else o.Cinsiyet = "E";
                int yas = random.Next(20,50);
                o.DogumTarihi = DateTime.Now.AddYears(yas*-1);
                o.Id = i;
                o.Ilce = FakeData.PlaceData.GetCounty();
                o.Sehir = FakeData.PlaceData.GetCity();
                o.Kapino = random.Next(1,220);
                olist.Add(o);

            }
        }
    }
}
