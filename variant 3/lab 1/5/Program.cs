using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string sentence = Console.ReadLine();
            bool is_real = true;
            foreach (char letter in sentence)
            {
                if (letter != '1' && letter != '0' && letter != ',')
                {
                    is_real = false;
                }
            }
            if (sentence.Split(',').Length < 3 && is_real && sentence[sentence.Length - 1] != ',')
            {
                Console.WriteLine("Может быть вещественным числом в двоичной системе счисления!");
            } else
            {
                Console.WriteLine("Не может быть вещественным числом в двоичной системе счисления!");
            }
            Console.ReadKey();
        }
    }
}
