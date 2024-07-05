using System;

namespace FindNumberAndLetter 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This program determines the number of letters and numbers in the entered text");

            Console.Write("Enter the text: ");
            string userInput = Console.ReadLine();

            int lettersCount = 0;
            int numbersCount = 0;

            string letters = "";
            string numbers = "";

            foreach (char c in userInput)
            {
                if (char.IsDigit(c))
                {
                    numbers += c;
                    numbersCount++;
                }
                else if (char.IsLetter(c))
                {
                    letters += c;
                    lettersCount++;
                }
            }

            Console.WriteLine($"the number of letters in the text : {lettersCount}");
            Console.WriteLine($"the number of numbers in the text : {numbersCount}");
            Console.ReadLine();
        }
    }
}