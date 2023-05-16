using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pract16_shvets
{
    class Program
    {
        static void DeleteSymbols()
        {
            text = string.Empty;
            char symbol;
            while (letters.Count!=0)
            {
                symbol = letters.Pop();
                if (symbol != '#')
                {
                    text += symbol.ToString();
                }
                else
                {
                    text = text.Remove(text.Length - 1, 1);
                }
            }
            
        }
        static string text = string.Empty;
        static Stack<char> letters = new Stack<char>();
        static void Main(string[] args)
        {
            string path;
            while (true)
            {
                Console.WriteLine("Введите название или путь к фалу");
                path = Console.ReadLine();
                if (File.Exists(path))
                    break;
                else
                    Console.WriteLine("Файл не найден");
            }
            StreamReader sr = File.OpenText(path);
             text = sr.ReadToEnd();
            if (text.Length == 0)
                Console.WriteLine("Файл пуст");
            else
            {
                for (int i = text.Length-1;i>=0; i--)
                    letters.Push(text[i]);
                DeleteSymbols();
                Console.WriteLine(text);
            }
            Console.ReadKey();
        }
    }
}
