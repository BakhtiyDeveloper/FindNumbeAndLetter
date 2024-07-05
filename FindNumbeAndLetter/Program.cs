using System;

namespace FindNumberAndLetter 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This program determines the number of letters and numbers in the entered text");

            string yesOrNo;
            do 
            {
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

                Console.WriteLine($"The number of letters in the text : {lettersCount}");
                Console.WriteLine($"The number of numbers in the text : {numbersCount}");
                Console.WriteLine($"Letters entered: {letters}");
                Console.WriteLine($"Numbers entered: {numbers}");


                Console.WriteLine();
                Console.WriteLine("Do you want to continue? (yes / no)");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo.ToLower() == "yes" || yesOrNo.ToLower() == "y");

            Console.WriteLine("Thank you for using our program");
            Console.ReadLine();
        }
    }
}