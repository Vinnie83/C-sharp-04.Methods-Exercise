namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int minNumber = GetMinNumber(number1, number2);
            minNumber = GetMinNumber(minNumber, number3);
            Console.WriteLine(minNumber);

        }

        private static int GetMinNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }

        }



    }
}