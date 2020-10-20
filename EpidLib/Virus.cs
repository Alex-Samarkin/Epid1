using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EpidLib
{
    public class Virus
    {
        public string Name { get; set; } = "SARS";
        public int IncubTime { get; set; } = 7;
        public int DiseaseTime { get; set; } = 14;
        public double InfectionProb { get; set; } = 0.02;
        public double LethalProb { get; set; } = 0.01;


        public override string ToString()
        {
            Type t = typeof(Virus);
            PropertyInfo[] propertyInfo = t.GetProperties();
            string s = base.ToString() + " ";
            foreach (var item in propertyInfo)
            {
                s += item.Name + " " + item.GetValue(this, null) + " ";
            }

            return s;
        }
    }
}
