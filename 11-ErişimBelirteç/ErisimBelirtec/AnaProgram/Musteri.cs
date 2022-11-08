using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaProgram
{
    public class Musteri
    //class private olunca projelerde gözükmüyor. 
    //internal olunca sadece tanımlı olduğu katmandaki projede gözüküyor.
    //public olunca tüm projelerde gözüküyor.
    
    {
        public int Id { get; set; }
        public string Unvan { get; set; }

        private string kkNo;

        public string GetKkNo()
        {
            return "*********" + kkNo.Substring(kkNo.Length - 2);
        }

        public void SetKkNo(string value)
        {
            kkNo = value;
        }

        protected string telNo;

        public string GetTelNo()
        {
            return "*******" + telNo.Substring(telNo.Length-4);
        }

        public void SetTelNo(string value)
        {
            telNo = value;
        }
    }
}
