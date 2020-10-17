using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Reflection;
using System.IO;

namespace EpidLib
{
    public class RndGen
    {
        public Random RGen { get; set; } = new Random();
        public int Seed { get; set; } = 0;

        public string CSVFile { get; set; } = "Data";

        public void Reset(int seed = 0)
        {
            Seed = seed;
            RGen = new Random(Seed);
        }
        public void Reset(int n, int seed = 0)
        {
            Seed = seed;
            RGen = new Random(Seed);
            RunInt(n);
        }

        public void RunDouble(int n)
        {
            for (int i = 0; i < n; i++)
            {
                RGen.NextDouble();
            }
        }
        public void RunInt(int n)
        {
            for (int i = 0; i < n; i++)
            {
                RGen.Next();
            }
        }

        public int Next(int a, int b, double probA = 0.50)
        {
            if (probA >= 1) return a;
            if (probA <= 0) return b;
            if (RGen.NextDouble() <= probA) return a;
            return b;
        }

        public double NextNorm(int n =12)
        {
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += (RGen.NextDouble() - 0.5);
            }

            return s * 2.0 / n;
        }

        public double NextNorm(double mean, double sx = 1, int n = 12)
        {

            return NextNorm()*sx+mean;
        }


        public override string ToString()
        {
            Type t = typeof(RndGen);
            PropertyInfo[] propertyInfo = t.GetProperties();
            string s = base.ToString() + " ";
            foreach (var item in propertyInfo)
            {
                s += item.Name + " " + item.GetValue(this, null) + " ";
            }

            return s;
        }

        public void ToCSV(double mean, double sx, int n)
        {
            string filename = this.CSVFile + ".csv";
            using (System.IO.StreamWriter file =
                       new System.IO.StreamWriter(this.CSVFile + ".csv", false))
            {
                for (int i = 0; i < n; i++)
                {
                    file.WriteLine($"{i};{NextNorm(mean, sx)}");
                }
            }
        }
    }
}
