using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_004
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 8;
            int operand2 = 0;
            Console.Write("Введите знак арифметической операции:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+": Console.WriteLine("{0}+{1}={2}",operand1,operand2,operand1+operand2);
                        break;
                case "-": Console.WriteLine("{0}-{1}={2}", operand1, operand2, operand1 - operand2);
                        break;
                case "*": Console.WriteLine("{0}*{1}={2}", operand1, operand2, operand1 * operand2);
                        break;
                case "/":
                    {
                        if (operand2 != 0)
                        {
                            Console.WriteLine("{0}/{1}={2}", operand1, operand2, operand1 / operand2);
                        }
                        else
                        {
                            Console.WriteLine("на ноль делить нельзя!");
                        }
                        break;
                    }
                default:
                        Console.WriteLine("вы ввели знак не арифметической операции");
                    break;
            }
            Console.ReadKey();


        }
    }
}
