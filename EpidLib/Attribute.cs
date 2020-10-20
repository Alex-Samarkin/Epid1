using System;

namespace EpidLib
{
    public class Attribute
    {
        /// <summary>
        /// имя атрибута, например, пол 
        /// </summary>
        public string Name { get; set; } = "Name";
        /// <summary>
        /// значение атрибута, например, м
        /// </summary>
        public string Value { get; set; } = "Name";
        /// <summary>
        /// поправка атрибута на вероятности заражения, длительности икуб периода, времени болезни, вероятности смерти
        /// </summary>
        public double Infection { get; set; } = 0;
        public double IncubTime { get; set; } = 0;
        public double DisTime { get; set; } = 0;
        public double Lethal { get; set; } = 0;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Value)}: {Value},\n" +
                   $"{nameof(Infection)}: {Infection}, {nameof(IncubTime)}: {IncubTime}, {nameof(DisTime)}: {DisTime}, {nameof(Lethal)}: {Lethal}";
        }
    }
}