using System;
using CalculationLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationLib calculation = new CalculationLib();
            int a = 15;
            int b = 5;
            Console.WriteLine(" a = {0}, b = {1}", a, b);
            Console.WriteLine(" a + b = {0}", calculation.Add(a, b));
            Console.WriteLine(" a - b = {0}", calculation.Subtract(a, b));
            Console.WriteLine(" a * b = {0}", calculation.Multiply(a, b));
            Console.WriteLine(" a / b = {0}", calculation.Divide(a, b));


        }
    }
}