using System;
using System.Collections.Generic;
using System.Text;

namespace EpidLib
{
    public class FromTo
    {
        public double From { get; set; } = 0;
        public double To { get; set; } = 0;

        public double Mean => (From + To) / 2;
        public double Range => (To - From);

        public double Sx2Sigma => Range / 4;
        public double Sx3Sigma => Range / 6;


        public override string ToString()
        {
            return $"{nameof(From)}: {From}, {nameof(To)}: {To}, {nameof(Mean)}: {Mean}, {nameof(Range)}: {Range}, {nameof(Sx2Sigma)}: {Sx2Sigma}, {nameof(Sx3Sigma)}: {Sx3Sigma}";
        }
    }
}
