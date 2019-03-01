using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int count = int.Parse(Console.ReadLine());
            char[] mas = new char[count];
            for (int i = 1; i < mas.Length + 1; i++)
            {
                Console.Write($"Введите элемент {i}: ");
                mas[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива с определением типов символов:");
            foreach (char elem in mas)
            {
                if (Char.IsDigit(elem))
                {
                    Console.WriteLine(elem + "- число");
                } else if (Char.IsSeparator(elem))
                {
                    Console.WriteLine(elem + "- знак препинания");          
                } else if (Char.IsLower(elem))
                {
                    Console.WriteLine(elem + "- буква в нижнем регистре");
                } else if (!Char.IsLower(elem) && Char.IsLetter(elem))
                {
                    Console.WriteLine(elem + "- буква в верхнем регистре");
                } else
                {
                    Console.WriteLine(elem + "- знак препинания");
                }
            }
            Console.ReadKey();
        }
    }
}
