using CoffeeHouse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Class
{
    public class Icecekler
    {
        public string IcecekAdi { get; set; }
        public decimal IcecekFiyati { get; set; }
        public int HazirlanmaSuresi { get; set; }
     
        public IcecekTuru Tur { get; set; }
    }
}
