using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 0 до 100:");
            string number = Console.ReadLine();
            byte num = Convert.ToByte(number);
            if (num <= 14)
            {
                Console.WriteLine("Указанное число попадает в промежуток от 0 до 14");
            }
            else if (num <= 35)
            {
                Console.WriteLine("Указанное число попадает в промежуток от 15 до 35");
            }
            else if (num <= 50)
            {
                Console.WriteLine("Указанное число попадает в промежуток от 36 до 50");
            }
            else if (num <= 100)
            {
                Console.WriteLine("Указанное число попадает в промежуток от 51 до 100");
            }
            else
            {
                Console.WriteLine("Указанное число не входит ни в один из имеющихся промежутков");
            }
            Console.ReadKey();
        }
    }
}
