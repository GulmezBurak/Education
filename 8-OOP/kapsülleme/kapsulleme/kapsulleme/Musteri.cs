using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KartNo { get => KartNo1; set => KartNo1 = value.Substring(0, 2) + "*************" + value.Substring(value.Length - 4); }
        private string KartNo1;
    }
}
