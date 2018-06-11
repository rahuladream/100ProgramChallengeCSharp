using System;
namespace HundredProgramChallenge
{
    class countTheElement
    {
        static void Main(string[] args)
        {
            int lim,s,count = 0;
            Console.WriteLine("Program #02 Coding Challenge");
            Console.WriteLine("Enter the limit up to");
            lim = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[lim];
            Console.WriteLine("Number you want to search");
            s = int.Parse(Console.ReadLine());
            for(int i=0; i<lim; i++)
            {
                Console.WriteLine("Enter the number " + i);
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            foreach(int o in a)
            {
                if( o == s)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of {0}'s in the Entered Number : {1} ", s, count);
            Console.Read();
        }
    }
}
