using System;
namespace SortingApplication
{
    class Sorting
    {
        static void SelectionSort(int[] array, int array_size)
        {
            int tmp, min_key;
            for (int j = 0; j < array_size - 1; j++)
            {
                min_key = j;

                for (int k = j + 1; k < array_size; k++)
                {
                    if (array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }
                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }
            Console.WriteLine("The Array After Selection Sort is: ");
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }

        
        static void Main(string[] args)
            {
                int array_size;
                Console.WriteLine("Enter the array size :");
                array_size = Convert.ToInt16(Console.ReadLine());
                int[] array = new int[array_size];
                for (int i = 0; i < array_size; i++)
                {
                    Console.WriteLine("Enter the value of {0} ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }
            SelectionSort(array, array_size);
            }
      }
}