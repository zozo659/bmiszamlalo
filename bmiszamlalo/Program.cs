using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace bmiszamlalo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<diak> list = new List<diak>();
            var sorok = File.ReadAllLines("bmi.txt", System.Text.Encoding.Latin1).Skip(1);
            foreach (var sor in sorok)

            {
                //Console.WriteLine(sor);
                string[] darabok = sor.Split(';');
                string nev = darabok[0];
                int eletkor = Convert.ToInt32(darabok[1]);
                int magassag = Convert.ToInt32(darabok[2]);
                int suly = Convert.ToInt32(darabok[3]);
                diak d = new diak(nev, eletkor, magassag, suly);
                list.Add(d);
            }
            foreach (var d in list)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("-------------");
            Console.WriteLine($"3. a, feladat: A diákok száma: {list.Count}");

            diak legmagasabb = list[0];
            foreach (var diak in list)
            {
                if (diak.Magasság > legmagasabb.Magasság)
                {
                    legmagasabb = diak;
                }
            }
            Console.WriteLine($"3. b, feladat: A legmagasabb diák:" + $"{legmagasabb.Név}, magasság:{legmagasabb.Magasság} cm");
            foreach (var d in list)
            {
                Console.WriteLine(d.Név + ":" + d.bmi());
            }
            double atlag = 0;
            foreach (var d in list)
            {
                atlag += d.Testsúly;
            }
            atlag /= list.Count;
            Console.WriteLine($"5.a.feladat átlagos testsúly:" + $"{atlag:F1} kg");

            int normalDb = 0;
            Console.WriteLine("5.b.feladat: Normál testtömegű diákok:");


            string fajlba  = "Név; BMI/n";
            foreach (var d in list)
            {
                double magassagm = d.Magasság / 100.0;
                double BMI = d.Testsúly / (magassagm * magassagm);
                fajlba += $"{d.Név}; {BMI:F1}/n";
            }
            File.WriteAllText("egezseges_diakok.txt", fajlba);


        }
    }
}
