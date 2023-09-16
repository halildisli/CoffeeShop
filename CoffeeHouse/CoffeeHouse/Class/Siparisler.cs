using CoffeeHouse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.Class
{
    public class Siparisler
    {
        public Boyut IcecekBoyutu { get; set; }
        public int Adet { get; set; }
        public int ToplamSure { get; set; }
        public decimal ToplamTutar { get; set; }
        public Icecekler SeciliIcecek { get; set; }
        public List<EkstraMalzemeler> EkstraMalzeme { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliIcecek.IcecekFiyati;
            if (IcecekBoyutu==Boyut.Orta)
            {
                ToplamTutar += ToplamTutar * 0.25m;
            }
            else if (IcecekBoyutu==Boyut.Buyuk)
            {
                ToplamTutar += ToplamTutar + 0.50m;
            }
            ToplamTutar += EkstraMalzeme.Sum(x => x.EkstraMalzemeFiyati);
            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            string ekstralar = "Ekstralar : " + Environment.NewLine;
            if (EkstraMalzeme.Count==0)
            {
                return $"İçecek Adı: {SeciliIcecek.IcecekAdi}, Adedi : {Adet}, Boyutu : {IcecekBoyutu}, Toplam Tutar : {ToplamTutar.ToString("c2")}";
            }
            foreach (var ekstra in EkstraMalzeme)
            {
                ekstralar += ekstra.EkstraMalzemeAdi + ",";
            }
            
            return $"İçecek Adı: {SeciliIcecek.IcecekAdi}, Adedi: { Adet}, Boyutu: {IcecekBoyutu}, { ekstralar} ToplamTutar : { ToplamTutar.ToString("c2")}";
           
        }
    }
}
