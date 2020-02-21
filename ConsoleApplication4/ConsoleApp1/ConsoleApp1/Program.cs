using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        programstart:

            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());

            bool isLessThan10 = myInt < 10;

            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);

            if (isBetween0And5 == false)
                goto programstart;

            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0And5);

            Console.WriteLine("Exactly one of the above is true? {0}", isLessThan10 ^ isBetween0And5);

            string resultString = (isLessThan10 == true) ? "Less than 10" : "Greater than or equal to 10";

            if (isLessThan10 == true)
            {
                // runs when exp is true
                resultString = "Number is less than 10";
            }
            else
            {
                // runs when exp is false
                resultString = "Number is greater than or equal to 10";
            }
            Console.ReadKey();
        }
    }
}
