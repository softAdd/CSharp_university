using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            char[] masOfLatin = new char[sentence.Length];
            int index = 0;
            foreach (char letter in sentence)
            {
                if (((letter >= 'a') && (letter <= 'z')) || ((letter >= 'A') && (letter <= 'Z')))
                {
                    masOfLatin[index] = letter;
                    index++;
                }
            }
            string newSentence = "";
            foreach(char symbol in masOfLatin)
            {
                newSentence += symbol.ToString();
            }
            Console.WriteLine("Новое предложение:");
            Console.WriteLine(newSentence);
            Console.ReadKey();
        }
    }
}
