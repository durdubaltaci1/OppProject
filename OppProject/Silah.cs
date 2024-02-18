using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppProject
{
    public abstract class Silah
    {
        public required string SilahModel { get; set; }
        public int MühimmatKapasite { get; set; }
        public double Agirlik { get; set; }
        public decimal SatisFiyat { get; set; }

        public abstract void AtesEt();
        public abstract void Doldur();
        public abstract void Temizle();
    }

    public class MPT : Silah
    {
        public override void AtesEt()
        {
            Console.WriteLine($"{SilahModel} MPT ateş edildi.");
        }

        public override void Doldur()
        {
            Console.WriteLine($"{SilahModel} MPT dolduruldu.");
        }

        public override void Temizle()
        {
            Console.WriteLine($"{SilahModel} MPT temizlendi.");
        }
    }

    public class MilliPiyade : Silah
    {
        public override void AtesEt()
        {
            Console.WriteLine($"{SilahModel} MilliPiyade tüfeği ates edildi.");
        }

        public override void Doldur()
        {
            Console.WriteLine($"{SilahModel} MilliPiyade tüfeği dolduruldu.");
        }

        public override void Temizle()
        {
            Console.WriteLine($"{SilahModel} MilliPiyade tüfeği temizlendi.");
        }
    }

    public class Keleş : Silah
    {
        public override void AtesEt()
        {
            Console.WriteLine($"{SilahModel} Keleş ateş edildi.");
        }

        public override void Doldur()
        {
            Console.WriteLine($"{SilahModel} Keleş dolduruldu.");
        }

        public override void Temizle()
        {
            Console.WriteLine($"{SilahModel} Keleş temizlendi.");
        }
    }
}
