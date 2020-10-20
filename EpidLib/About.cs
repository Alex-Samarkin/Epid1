using System;

namespace EpidLib
{
    public class About
    {
        public static string Info => "Библиотека классов для моделирования развития эпидемии";
        public static int Ver => 0;
        public static int SubVer => 0;
        public static int MinorVer => 1;
        public static string Suff => "alpha";
        public static string Version => $"{Ver}.{SubVer}.{MinorVer}.{Suff}";

        public static string ToString()
        {
            return Info + "\n" + Version;
        }
    }
}
