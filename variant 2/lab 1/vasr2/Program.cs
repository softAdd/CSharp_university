using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            var sentence = Console.ReadLine();
            Console.WriteLine("Введите слово:");
            var word = Console.ReadLine();
            var words = sentence.Split(' ');
            var is_present = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == word.ToLower())
                {
                    is_present = true;
                    break;
                }
            }
            if (is_present)
            {
                Console.Write($"Слово \"{word}\" встречается в предложении.");
            } else
            {
                Console.WriteLine($"Слово \"{word}\" не встречается в предложении.");
            }
            Console.ReadKey();

        }
    }
}
