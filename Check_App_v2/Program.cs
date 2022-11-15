using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_App_v2
{
    class Program
    {
        static void Main(string[] args)
        {//Динамическое моделирование счета в кредитной организации                       

            Check<int> check1 = new Check<int>();
            check1.Input();
            check1.GetInfo();
            Console.WriteLine(check1.GetInfo());

            Check<string> check2 = new Check<string>();
            check2.Input();
            check2.GetInfo();
            Console.WriteLine(check2.GetInfo());
           
            Console.ReadKey();
        }
    }
}
