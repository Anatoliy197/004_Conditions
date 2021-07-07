using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на русском языке:");
            string word = Console.ReadLine();
            switch(word)
            {
                case "наводнение":
                    {
                        Console.WriteLine("deluge");
                        break;
                    }
                case "солнечно":
                    {
                        Console.WriteLine("sunny");
                        break;
                    }
                case "холодно":
                    {
                        Console.WriteLine("cold");
                        break;
                    }
                case "ветер":
                    {
                        Console.WriteLine("wind");
                        break;
                    }
                case "вода":
                    {
                        Console.WriteLine("water");
                        break;
                    }
                case "молния":
                    {
                        Console.WriteLine("lightning");
                        break;
                    }
                case "снег":
                    {
                        Console.WriteLine("snow");
                        break;
                    }
                case "гроза":
                    {
                        Console.WriteLine("thunderstorm");
                        break;
                    }
                case "шторм":
                    {
                        Console.WriteLine("storm");
                        break;
                    }
                case "метель":
                    {
                        Console.WriteLine("blizzard");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели слово, которого нет в словаре");
                        break;
                    }
            
            }
            Console.ReadKey();

        }
    }
}
