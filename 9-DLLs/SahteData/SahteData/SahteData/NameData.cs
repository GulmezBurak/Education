using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteData
{
    public static class NameData
    {
        public static string GetFirstName()
        {
            Random rnd = new Random();
            string[] adlar = { "Esra", "Burak", "Batuhan", "Alper", "Aleyna", "Tuğçe", "Behlül", "Tugay", "Tunç", "Zeynep", "Cem","Şevval","Mete","Ahmet","Ayşe","Erdem","Emre","Emine","Fazilet","Azra","Ömer" };
            string ad = adlar[rnd.Next(adlar.Length)];
            return ad;
        }
        public static string GetSurName()
        {
            Random rnd = new Random();
            string[] soyadlar = { "Çetin", "Gülmez", "Aydın", "Yiğit", "Yargıcı", "Utkan", "Tan", "Evci", "Turan", "Şeho", "Demir", "Sarıçiçek", "Saçu", "Cimbek", "Karakoç", "Yılmaz", "Akın", "Sarıkaya", "Ertuğrul", "Akın", "Güneş" };
            string soyad = soyadlar[rnd.Next(soyadlar.Length)];
            return soyad;
        }
    }
    public static class PlaceData
    {
        public static string GetCity()
        {
            Random rnd = new Random();
            string[] sehirler = { "İstanbul", "Ankara", "Diyarbakır", "İzmir", "Kocaeli", "Siirt", "Giresun", "Ardahan", "Kars", "Muğla", "Antalya", "Edirne", "Çanakkale", "Balıkesi", "Amasya", "Sivas", "Erzincan", "Bursa"};
            string sehir = sehirler[rnd.Next(sehirler.Length)];
            return sehir;
        }
        public static string GetCounty()
        {
            Random rnd = new Random();
            string[] ilceler = { "Küçükçekmece", "Bakırköy", "Bahçelievler", "Acıbadem", "Kadıköy", "Avcılar", "Beylikdüzü", "Şişli", "Zeytinburnu", "Göztepe", "Sultanbeyli", "Maltepe", "Kızılay", "Nilüfer", "Akyurt", "Dicle", "Bornova", "Buca" ,"Marmaris"};
            string ilce = ilceler[rnd.Next(ilceler.Length)];
            return ilce;
        }
        public static string GetStreetName()
        {
            Random rnd = new Random();
            string[] sokaklar = { "Çiğdem", "Manolya", "Pembe Ay", "Lale", "Kadife", "Hedef", "Çiçek", "Gül", "Elmalıdere", "Silahşör", "Barbaros", "Emek", "Limon", "Susam", "Zeytin", "Ananas", "Ahu", "Gülderen", "Karabal" };
            string sokak = sokaklar[rnd.Next(sokaklar.Length)];
            return sokak;
        }
    }
}
