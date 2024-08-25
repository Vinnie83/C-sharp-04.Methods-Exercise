namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{PrintAllCharsBetween(firstChar, secondChar)}");

            //char first = char.Parse(Console.ReadLine());
            //char second = char.Parse(Console.ReadLine());

            //if (first > second)
            //{
            //    char swapTemp = first;
            //    first = second;
            //    second = swapTemp;
            //}

            //PrintBetween(first, second);

        }

        //private static void PrintBetween(char first, char second)
        //{
        //    for (int i = first + 1; i < second; i++)
        //    {
        //        Console.Write($"{(char)i} ");
        //    }
        //}

        private static string PrintAllCharsBetween(char firstChar, char secondChar)
        {
            string result = "";

            if (firstChar < secondChar)
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    result += $"{(char)i} ";
                }

            }
            else
            {
                for (int j = secondChar + 1; j < firstChar; j++)
                {
                    result += $"{(char)j} ";
                }
            }


            return result;


        }
    }
}