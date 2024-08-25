namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            Console.WriteLine(GetMiddleChar(word));
        }

        private static string GetMiddleChar(string word)
        {
            string result = " ";

            if (word.Length % 2 == 0)
            {

                int middle = word.Length / 2;

                char firstChar = word[middle];
                char secondChar = word[middle - 1];
                result = $"{secondChar}{firstChar}";

            }


            if (word.Length % 2 != 0)
            {
                int middle = word.Length / 2;
                char middleChar = word[middle];
                result = $"{middleChar}";

            }

            return result;


        }
    }
}