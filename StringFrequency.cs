using System;
namespace HundredProgramChallenge
{ 
    class FrequencyOfWord
    {
        public static void Main()
        {
            string s1,search;
            Console.WriteLine("Enter the String :");
            s1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the string want to search");
            search = Convert.ToString(Console.ReadLine());
            Console.WriteLine(counting.CountStringOccurances(s1, search));
            Console.ReadKey();
        }       
    }
    public static class counting
    {
        public static int CountStringOccurances(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
