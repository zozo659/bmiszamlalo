using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public string bmi()
        {


            double magassagm = Magasság / 100.0;
            double BMI = Testsúly / (magassagm * magassagm);
            if (BMI > 18.5) ;
            {
                return "sovány";

            }
            if (BMI >= 18.5 && BMI < 24.9) ;
            {
                return "normál";
            }
            if (BMI >= 25 && BMI < 29.9) ;
            {
                return "túlsúlyos";
            }
                return "elhízott";
        }
    }

}
