using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201123_2
{
    class Kocsog :IAsztalonLevo
    {
        public string SzarmazasiHely { get; set; }
        public float PiaciAr { get; set; }
        public bool Torott { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }

        public string GetInfo()
        {
            return 
                $"Ez egy {SzarmazasiHely}-i köcsög {PiaciAr} Ft-ot ér\n" +
                $"Jelenleg a({X};{Y}) pozíción van" +
                $"{(Torott ? "már eltört" : "még egyben van")}";
        }
    }
}
