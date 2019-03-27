using System;
using System.Text;

namespace PasswordGenerator
{
    public static class Password
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTVZXYW";
        private const string LowerLetters = "abcdefghijklmnopqrstvzxyw";
        private const string Digits = "0123456789";
        private const string SpecialChars = ".,/\':|}!@#$%^&*()_+-";
        private const string AllInOne = CapitalLetters + LowerLetters + Digits + SpecialChars;
        private static Random rnd = new Random();

        private static char GetRandomCharFromString(string setOfChars)
        {
            int randomIndex = rnd.Next(setOfChars.Length);
            char capitalLetter = setOfChars[randomIndex];
            return capitalLetter;
        }
        private static void InsertInRandomPosition(StringBuilder password, char singleChar)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, singleChar);
        }

        public static string GeneratePassword()
        {
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 1; i <= 2; i++)
            {
                char randomChar = GetRandomCharFromString(CapitalLetters);
                InsertInRandomPosition(passwordBuilder, randomChar);
            }
            for (int i = 1; i <= 2; i++)
            {
                char randomChar = GetRandomCharFromString(LowerLetters);
                InsertInRandomPosition(passwordBuilder, randomChar);
            }
            for (int i = 1; i <= 1; i++)
            {
                char randomChar = GetRandomCharFromString(Digits);
                InsertInRandomPosition(passwordBuilder, randomChar);
            }
            for (int i = 1; i <= 3; i++)
            {
                char randomChar = GetRandomCharFromString(SpecialChars);
                InsertInRandomPosition(passwordBuilder, randomChar);
            }

            int nextRandomPassMembers = rnd.Next(8);

            for (int i = 0; i < nextRandomPassMembers; i++)
            {
                char randomChar = GetRandomCharFromString(AllInOne);
                InsertInRandomPosition(passwordBuilder, randomChar);
            }
            return passwordBuilder.ToString();
        }
    }
}
