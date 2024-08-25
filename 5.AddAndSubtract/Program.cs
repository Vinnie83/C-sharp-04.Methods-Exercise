namespace _5.AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());


            int sumResult = SumTwoNumbers(number1, number2);

            
            Console.WriteLine(SubtractTwoNumbers(sumResult, number3));


        }

        private static int SubtractTwoNumbers(int sumResult, int number3)
        {
            int result = sumResult - number3;

            return result;
        }

        private static int SumTwoNumbers(int number1, int number2)
        {
            int result = number1 + number2;
           
            return result;
        }


    }
}