using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            if (double.TryParse(str, out double real) && !int.TryParse(str, out int num))
            {
                Console.WriteLine("Вещественное число.");
            } else
            {
                Console.WriteLine("Не вещественное число.");
            }
            Console.ReadKey();
        }
    }
}
