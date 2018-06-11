using System;
using System.Linq;

namespace SortingApplication
{  
  class Sorting
    { 
    static void bubbleSort(int[] values, int n)
    {
        int i, j, temp;
        for(i=0; i<n; i++)
        {
            for(j=0; j<n-i-1; j++)
            {
                if(values[j] > values[j+1])
                {
                    temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                }
            }
        }
        for(i =0; i<n; i++)
        {
            Console.Write("{0} ", values[i]);
               
        }
            Console.ReadKey();
  }
        static void Main()
        {
            int n;
            
            Console.WriteLine("Enter the number of value want to sort");
            n = Convert.ToInt16(Console.ReadLine());
            int[] data = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Please enter {0} element", i);
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sorting.bubbleSort(data, n);
        }
    }
}