using System;
using System.Linq;

namespace SearchingApplication
{
    class Search
    {
       static int BinarySearch(int[] values, int len, int target)
        {
            int max = (len - 1);
            int min = 0;
            int guess;
            int step = 0;
            while(max >= min)
            {
                guess = (max + min) / 2;
                step++;
                if(values[guess] == target)
                {
                    Console.WriteLine("No. of step required is {0}", step);
                    return (guess);
                }
                else if(values[guess] > target)
                {
                    max = (guess - 1);
                }
                else
                {
                    min = (guess + 1);
                }
            }
            return -1;
        }
        static void Main()
        {
            int[] data = { 2, 3, 6, 8, 12, 14, 20, 22, 24, 26 };
            int n = data.Length;
            int target = 14;
            int result = BinarySearch(data, n, target);
            if (result == -1)
            {
                Console.WriteLine("Element is not present in the given array.");
            }
            else
            {
                Console.WriteLine("Element is present at index: {0}", result);
            }
            Console.ReadKey();
        }
    }

}
