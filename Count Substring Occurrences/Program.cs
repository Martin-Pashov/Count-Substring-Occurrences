using System;
using System.Text;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string input = Console.ReadLine();

            Console.Write("Enter a pattern: ");
            string pattern = Console.ReadLine();

            int count = 0;
            int index = input.IndexOf(pattern);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(pattern, index + 1);
            }
            Console.WriteLine($"\r\nThe amount of occurrences is: {count}");
        }
    }
}
