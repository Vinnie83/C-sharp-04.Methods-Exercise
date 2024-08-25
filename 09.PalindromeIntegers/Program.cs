namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string number;
            while((number = Console.ReadLine()) != "END") 
            {
                Console.WriteLine(IsPalindrome(number));
            }
           
        }

        private static bool IsPalindrome(string input)
        {

            string first = input.Substring(0, input.Length / 2);
            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);



        }
    }
}