namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            bool checkLengthOk = CheckLength(password);
            bool checkSymbolsOk = CheckSpecialSymbol(password);
            bool checkDigitsOk = CheckDigits(password);

            if (!checkLengthOk)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!checkSymbolsOk)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!checkDigitsOk)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (checkLengthOk && checkSymbolsOk && checkDigitsOk)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool CheckLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
           
            
        }

        private static bool CheckSpecialSymbol(string password)
        {
            foreach (var symbol in password)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckDigits(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }
            return true;
        }
    }
}