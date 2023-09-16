using CoffeeHouse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Class
{
    public class Personel
    {
        public Personel(string _name, bool _bostaMi, CalisanPozisyon _pozisyon)
        {
            Name = _name;
            BostaMi = _bostaMi;
            Pozisyon = _pozisyon;
        }

        public string Name { get; set; }
        public bool BostaMi { get; set; }
        public CalisanPozisyon Pozisyon { get; set; }

    }
}
