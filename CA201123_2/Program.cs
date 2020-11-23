using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201123_2
{
    class Program
    {
        static void Main()
        {
            var asztal = new IAsztalonLevo[5, 5];

            asztal[0, 0] = new Macska()
            {
                Nev = "Cirmi",
                X = 0,
                Y = 0,
                Fajta = "perzsa",
            };

            asztal[4, 4] = new Kocsog()
            {
                SzarmazasiHely = "Kína",
                X = 4,
                Y = 4,
                PiaciAr = 12000,
            };

            foreach (var al in asztal)
            {
                if (al != null) Console.WriteLine(al.GetInfo());
            }

            Console.ReadKey();
        }
    }
}
