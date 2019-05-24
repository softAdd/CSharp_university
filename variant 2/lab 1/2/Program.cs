using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr = Console.ReadLine();

            int count = 0, index = 0;
            while ((index = str.IndexOf(substr, index) + 1) != 0) count++;
            Console.WriteLine("Подстроку встретилась: " + count + "раз.");
            Console.ReadKey();
        }
    }
}
