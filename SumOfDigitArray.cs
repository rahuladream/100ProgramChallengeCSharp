using System;
namespace HundredProgramChallenge
{
    class SumOfDigitNumber
    {
        static void Main(string[] args)
        {
            int[] num = new int[50];
            Console.WriteLine("Program #03 Coding Challenge");
            Console.WriteLine("How many numbers you want to add?");
            int count = Convert.ToInt16(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                Console.WriteLine("Enter the number" + i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach(var item in num)
            {
                sum += item;
            }
            Console.WriteLine("The sum of number is " + sum);
            Console.ReadKey();
        }
    }
}
