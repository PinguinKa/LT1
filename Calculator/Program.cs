using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2;
            char op;
            Console.WriteLine("First number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    if (num2 == 0) Console.WriteLine("Division by zero");
                    else Console.WriteLine("{0}/{1}={2}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}