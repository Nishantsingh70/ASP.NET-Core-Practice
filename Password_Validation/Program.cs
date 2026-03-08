using System.Security.Cryptography.X509Certificates;

namespace Password_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Please enter the complex password: ");
            string password = Console.ReadLine();

            bool isValid = Password_Validate(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid!");
            }
            else
            {
                Console.WriteLine("""                
                    Password is invalid! Please follow the rules: 
                    -At least 8 characters long
                    -Contains at least one uppercase letter
                    -Contains at least one lowercase letter
                    -Contains at least one digit
                    -Contains at least one special character
                    
                    """);
            }

        }

        static bool Password_Validate(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => ! char.IsLetterOrDigit(ch));

            return hasUpper && hasLower && hasDigit && hasSpecialChar;
        }
    }
}
