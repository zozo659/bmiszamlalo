using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiszamlalo
{
    /*Név;Életkor;Magasság;Testsúly
Kiss Péter;16;175;68
    */
    public class diak
    {
        public string Név { get; set; }
        public int Életkor { get; set; }
        public int Magasság { get; set; }
        public int Testsúly { get; set; }

        public diak(string név, int életkor, int magasság, int testsúly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Testsúly = testsúly;
        }
        public override string? ToString()
        {
            return $"{Név} {Életkor}éves {Magasság}cm {Testsúly}kg";
        }
    }

}
