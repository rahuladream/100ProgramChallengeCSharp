using System;
namespace SortingApplication
{
    class Sorting
    {
        static void InsertionSort(int[] data, int length)
        {
            int i, j, key;
            for(i=0; i<length; i++)
            {
                j = i;
                while (j > 0 && data[j-1] > data[j])
                {
                    key = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = key;
                    j--;
                }
            }
        }
       static void PrintArry (int[] data, int length)
        {
            foreach(int value in data)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
        static void Main()
        {
            int i = 0;
            Console.WriteLine("Enter number of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[length];
            while(i < length)
            {
                Console.WriteLine("Please enter array value {0} ", i);
                data[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Sorting.InsertionSort(data, length);
            Console.WriteLine("Sorted array is :");
            Sorting.PrintArry(data, length);        }
    }
}
