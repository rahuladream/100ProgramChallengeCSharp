using System;
namespace SearchingApplication
{
    class Search
    {
        static int LinearSearch(int[] value, int search)
        {
            for(int i=0; i<=value.Length; i++)
            {
                if(value[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] data = { 4, 2, 6, 8, 9, 22, 12 };
            int tobeSearch = 12;
            Console.WriteLine("Found at {0}", LinearSearch(data, tobeSearch));
            Console.ReadKey();
        }
    }
}