using System.Linq.Expressions;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetCountVowels(input));
        }

        private static int GetCountVowels(string input)
        {
            int count = 0;

            input = input.ToLower();

            foreach (var symbol in input )
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'u' || symbol == 'i'  )
                {
                    count++;
                }
            }


            return count;
        }
    }
}