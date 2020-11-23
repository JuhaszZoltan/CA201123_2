using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201123_2
{
    class Macska : IAsztalonLevo
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Nev { get; set; }
        public string Fajta { get; set; }

        public string GetInfo()
        {
            return 
                $"Ez egy {Fajta} macska, úgy hívják, hogy {Nev}\n" +
                $"Jelenleg a ({X};{Y}) pozíción van";
        }
    }
}
