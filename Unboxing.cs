using System;
namespace HundredProgramChallenge
{ 
    class Unboxing
    {
        int data;
        void insert(object x)
        {
            data = (int)x * 5;
        }
        object delete()
        {
            data = 0;
            return (object)data;
        }
        public static void Main()
        {
            Unboxing s = new Unboxing();
            s.insert(20);
            Console.WriteLine("Data :{0}", s.data);
            Console.WriteLine("New Data : {0}", s.delete());
            Console.ReadLine();
        }
    }
}
