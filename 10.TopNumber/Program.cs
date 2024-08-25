namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);   

        }

        private static void TopNumber(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;

                bool isTopNumber = false;

                string topCurrentNumber = "";

                int sumDigits = 0;

                bool isOneDigitOdd = false;
                bool isDivisible = false;

                while (currentNumber > 0)
                {
                   
                    int currentDigit = currentNumber % 10;

                    if (currentDigit % 2 != 0)
                    {
                        isOneDigitOdd = true;
                    }

                    sumDigits += currentDigit;

                    currentNumber /= 10;

                    
                    topCurrentNumber += $"{currentDigit}";
                    
                    
                }

                if (sumDigits % 8 == 0)
                {
                    isDivisible = true;
                }

                if (isDivisible && isOneDigitOdd)
                {
                    isTopNumber = true;
                }

                if (isTopNumber)
                {
                    char[] charArray = topCurrentNumber.ToCharArray();
                    Array.Reverse(charArray);
                    string reversedTopCurrentNumber = new string(charArray);

                    Console.WriteLine($"{reversedTopCurrentNumber}");
                }
            }


            }       

        }
        
    
}