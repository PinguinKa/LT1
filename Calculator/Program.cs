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
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
            }
            Console.ReadLine();
        }
    }
}