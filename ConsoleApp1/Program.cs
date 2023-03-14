using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prob1
            Console.Write("input number: ");
            double inch = Convert.ToDouble(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("{0} inch la {1}cm.", inch, cm);
        }
    }
}
