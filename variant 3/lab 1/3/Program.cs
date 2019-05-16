using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            var str = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            var sym = char.Parse(Console.ReadLine());
            var words = str.Split(' ');
            str = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                var space = words[i] + sym;
                str += space;
                if (i == words.Length - 2)
                {
                    str += words[i + 1];
                }
            }
            Console.Write(str);
            Console.ReadKey();
        }
    }
}
