using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProgram
{
    public class Kurumsal:Musteri
    {
        public void TelNoYaz()
        {
            Console.WriteLine(GetTelNo().Substring(GetTelNo().Length-4));
        }
        public void KkNoYaz()
        {
            //
        }
    }
}
