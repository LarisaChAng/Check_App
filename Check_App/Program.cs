using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_App
{
    class Program
    {
        static void Main(string[] args)
        {//Моделирование счета в кредитной организации

            Console.WriteLine("Введите ФИО клиента");
            string name = Console.ReadLine();

            Console.WriteLine("Введите номер счета (числовой):");
            int numInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите баланс");
            double sum = Convert.ToDouble(Console.ReadLine());

            Check<int> check1 = new Check<int>(numInt, sum, name);
            Console.WriteLine(check1.GetInfo());

            Console.WriteLine("Введите ФИО клиента");
            name = Console.ReadLine();

            Console.WriteLine("Введите номер счета (строковый):");
            string numString = Console.ReadLine();

            Console.WriteLine("Введите баланс");
            sum = Convert.ToDouble(Console.ReadLine());

            Check<string> check2 = new Check<string>(numString, sum, name);
            Console.WriteLine(check2.GetInfo());

            Console.ReadKey();
        }
    }
}
