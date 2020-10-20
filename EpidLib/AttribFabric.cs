using System;
using System.Collections.Generic;
using System.Text;

namespace EpidLib
{
    public class AttribFabric
    {
        /// <summary>
        /// имя атрибута
        /// </summary>
        public string AttrName { get; set; }
        /// <summary>
        /// таблица частот для генерации значений атрибута
        /// </summary>
        public FreqTable FreqTable { get; set; } = new FreqTable();
        /// <summary>
        /// поправка на вероятность заражения
        /// </summary>
        public FromToPercent InfestProb { get; set; } = new FromToPercent();
        /// <summary>
        /// поправка на время инкубационного периода
        /// </summary>
        public FromToPercent IncubTime { get; set; } = new FromToPercent();
        /// <summary>
        /// поправка на время заболевния
        /// </summary>
        public FromToPercent DisTime { get; set; } = new FromToPercent();
        /// <summary>
        /// поправка на вероятность смерти
        /// </summary>
        public FromToPercent LethalProb { get; set; } = new FromToPercent();
        /// <summary>
        /// генератор случайных чисел
        /// </summary>
        public RndGen RndGen { get; set; } = new RndGen();


        public Attribute GenerateAttribute()
        {
            Attribute res = new Attribute();

            res.Name = AttrName;


            return res;
        }

    }
}
