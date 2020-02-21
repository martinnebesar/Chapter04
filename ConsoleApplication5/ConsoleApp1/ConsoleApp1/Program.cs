using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 > var2)
                    comparison = "greater than";
                else
                    comparison = "equal to";

            }
            Console.WriteLine("The first number is {0} the second number.", comparison);
            Console.ReadKey();
        }
    }
}
