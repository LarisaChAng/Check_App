using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_App
{
    internal class Check<T>
    {
        public T Num { get; set; }
        public double Sum { get; set; }
        public string Name { get; set; }

        public Check(T num, double sum, string name)
        {
            Num = num;
            Sum = sum;
            Name = name;
        }

        public string GetInfo()
        {
            return $"Счет: {Num}.\nБаланс: {Sum}.\nФИО клиента: {Name}.";
        }
    }
}
