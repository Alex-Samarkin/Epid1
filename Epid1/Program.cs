using System;
using EpidLib;

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
        }
    }
}
