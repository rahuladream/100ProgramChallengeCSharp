using System;
namespace HundredProgramChallenge
{ 
    class ReverseNumber
    {
        static void Main(string[] args)
        {
        int num, rev = 0 ;
        Console.WriteLine("Program #04 Coding Challenge");
        num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rev = rev * 10;
                rev = rev + num % 10;
                num = num / 10;
            }
        Console.WriteLine("Reverse of the number " + rev);
        Console.ReadKey();
        }
    }
}
