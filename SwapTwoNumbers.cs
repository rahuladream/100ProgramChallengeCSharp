using System;
namespace HundredProgramChallenge
{
    class SwapTwoNumber
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Program #02 Coding Challenge");
            Console.WriteLine("First Number?");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Second Number?");
            b = Convert.ToInt16(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + a);
            Console.Write("\nSecond Number : " + b);
            Console.Read();
        }
    }
}
