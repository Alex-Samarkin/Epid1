using System;
using EpidLib;
using Attribute = EpidLib.Attribute;

namespace Epid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(About.ToString());
            EpidLib.Virus v = new EpidLib.Virus();
            Console.WriteLine(v.ToString());
            RndGen rndGen = new RndGen();
            rndGen.Reset();
            Console.WriteLine(rndGen.ToString());
            for (int i = 0; i < 250; i++)
            {
                Console.WriteLine(rndGen.NextNorm());
            }

            rndGen.ToCSV(0, 1, 1500);

            Attribute attr = new Attribute();

            Console.WriteLine(attr);

            FreqTable ft = new FreqTable();
            ft.Append("male",0.48);
            ft.Append("female", 0.52);

            Console.WriteLine(ft);

            ft.Cumulative = true;
            Console.WriteLine(ft);
            ft.Cumulative = false;
            Console.WriteLine(ft);

            FromTo diap1 = new FromTo() {From = 0, To = 1};
            Console.WriteLine(diap1);

            FromToPercent diap2 = new FromToPercent() { FromPercent = 0.2, ToPercent = 0.3 };
            Console.WriteLine(diap2);

        }
    }
}
