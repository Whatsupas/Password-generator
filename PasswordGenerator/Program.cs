using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string password = Password.GeneratePassword();
                Console.WriteLine($"Random password: {password}");
                Console.WriteLine($"Password length: {password.Length}");
                Console.WriteLine();
            }
        }
    }
}
