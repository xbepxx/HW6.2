using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.");
            string textinsert = Console.ReadLine();
            textinsert = textinsert.Replace(" ", "");
            char[] charArray = textinsert.ToCharArray();
            bool a = true;
            for (int i = 0; i < charArray.Length/2; i++)
            {
                if (charArray[i] != charArray[charArray.Length - i - 1])
                {
                    a = false;
                }
            }
            Console.WriteLine(((a) ? "Предложение является" : "Предложение не является") + " палиндромом");
            Console.ReadKey();
        }
    }
}
