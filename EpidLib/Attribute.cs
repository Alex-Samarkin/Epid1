using System;

namespace EpidLib
{
    public class Attribute
    {
        /// <summary>
        /// ��� ��������, ��������, ��� 
        /// </summary>
        public string Name { get; set; } = "Name";
        /// <summary>
        /// �������� ��������, ��������, �
        /// </summary>
        public string Value { get; set; } = "Name";
        /// <summary>
        /// �������� �������� �� ����������� ���������, ������������ ���� �������, ������� �������, ����������� ������
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