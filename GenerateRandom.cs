using System;
class HundredProgramChallenge
{
    class RandomNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Some Random Numbers are : ");
            Console.WriteLine("\n Press enter to generate more");
            for(int i=1; i<20; i++)
            {
                RandFunc();
            }
        }
        static Random r = new Random();
        public static void RandFunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}