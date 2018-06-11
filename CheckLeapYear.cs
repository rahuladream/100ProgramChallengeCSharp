using System;
namespace HundredProgramChallenge
{
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program #02 Coding Challenge");
            leapyear obj = new leapyear();
            obj.readData();
            obj.leap();
        }
        int y;
        public void readData()
        {
            Console.WriteLine("Enter the year in four digit");
            y = Convert.ToInt32(Console.ReadLine());
        }   
        public void leap()
        {
            if((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year", y);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", y);
            }
            Console.ReadLine();
        }
           
        }
    }
