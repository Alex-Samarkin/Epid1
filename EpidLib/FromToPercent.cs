using System;
using System.Collections.Generic;
using System.Text;

namespace EpidLib
{
    public class FromToPercent : FromTo
    {
        /// <summary>
        /// from 1 (lover)
        ///  0.2 => 1-0.2 = 0.8
        /// -0.1 => 1-(-0.1) = 1.1
        /// </summary>
        public double FromPercent
        {
            get => 1 - From;
            set => From = 1 - value;
        }
        /// <summary>
        /// from 1 (upper)
        ///  0.2 => 1+0.2 = 1.2
        /// -0.1 => 1-(-0.1) = 1.1
        /// </summary>
        public double ToPercent
        {
            get => To-1;
            set => To = 1 + value;
        }

        public FromTo FromTo => new FromTo() { From = 1 - FromPercent, To = 1 + ToPercent };

        public double Relation => From!=0 ? To / From : 0;
        public double LogRel => Relation > 0 ? Math.Log(Relation) : 0;

        public double LogFrom => From > 0 ? Math.Log(From) : 0;
        public double LogTo => To > 0 ? Math.Log(To) : 0;

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(FromPercent)}: {FromPercent}, {nameof(ToPercent)}: {ToPercent}, {nameof(FromTo)}: {FromTo}";
        }
    }
}
