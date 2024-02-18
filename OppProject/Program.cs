using System.Xml;

namespace OppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mpt = new MPT
            {
                SilahModel = "MPT-76",
                MühimmatKapasite = 10,
                Agirlik = 1.5,
                SatisFiyat = 500
            };

            var piyadeTüfeği = new MilliPiyade
            {
                SilahModel = "MPT-55",
                MühimmatKapasite = 20,
                Agirlik = 2.0,
                SatisFiyat = 600
            };

            var AK = new Keleş
            {
                SilahModel = "AK-47",
                MühimmatKapasite = 30,
                Agirlik = 3.0,
                SatisFiyat = 7000
            };

            var silahlar = new List<Silah> { mpt, piyadeTüfeği, AK };

            foreach (var silah in silahlar)
            {
                Console.WriteLine($"{silah.SilahModel,-25}{silah.MühimmatKapasite,-20}{silah.Agirlik,-15}{silah.SatisFiyat}");
            }
        }
        
    }
}
