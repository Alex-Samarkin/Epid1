using System;
using System.Collections.Generic;
using System.Text;

namespace EpidLib
{
    public class FreqTable
    {
        public Dictionary<string,double> table { get; set; } = new Dictionary<string, double>();

        public Dictionary<string, double>.KeyCollection Keys => table.Keys;
        public Dictionary<string, double>.ValueCollection Values => table.Values;

        public void Append(string k, double v) => table.Add(k, v);

        private bool _Cumulative = false;

        public bool Cumulative
        {
            get => _Cumulative;
            set => SetCumulative(value);
        }

        private void SetCumulative(bool value)
        {
            if (_Cumulative != value)
            {
                _Cumulative = value;
                Dictionary<string, double> table1 = new Dictionary<string, double>();
                if (_Cumulative == true)
                {
                    double s = 0;
                    foreach (KeyValuePair<string, double> pair in table)
                    {
                        double f = pair.Value + s;
                        table1.Add(pair.Key,f);
                        s = f;
                    }

                    table = table1;
                }
                else
                {
                    double s = 0;
                    foreach (KeyValuePair<string, double> pair in table)
                    {
                        double f = pair.Value - s;
                        table1.Add(pair.Key, f);
                        s = f;
                    }

                    table = table1;
                }
            }
        }

        public override string ToString()
        {
            string s1 = $"{nameof(table)}: {table}, {nameof(Keys)}: {Keys}, {nameof(Values)}: {Values}, {nameof(Cumulative)}: {Cumulative}";

            string s2 = "";

            foreach (KeyValuePair<string, double> pair in table)
            {
                s2 += $"{pair.Key}\t{pair.Value}\n";
            }

            return s1 + "\n" + s2;

        }
    }
}
