using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_App_v2
{
    internal class Check<T>
    {
        public T Num { get; set; }
        public double Sum { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return $"Счет: {Num}.\nБаланс: {Sum}.\nФИО клиента: {Name}.";
        }

        public void Input()
        {
            Console.WriteLine("Введите ФИО клиента");
            Name = Console.ReadLine();

            Console.WriteLine("Введите номер счета:");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите баланс");
            Sum = Convert.ToDouble(Console.ReadLine());
        }
    }
}
