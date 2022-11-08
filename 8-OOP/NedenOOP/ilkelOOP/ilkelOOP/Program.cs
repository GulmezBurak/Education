using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkelOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ali", "Veli", "Ayşe" };
            int[] Idler = { 10, 20, 30 };
            Console.WriteLine("Id giriniz");
            int index = Convert.ToInt32(Console.ReadLine());
            int indis = Array.IndexOf(Idler, index);
            Console.WriteLine("İsim: " + isimler[indis]);
            Console.ReadLine();
        }
    }
}
