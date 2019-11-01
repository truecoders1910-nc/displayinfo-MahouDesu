using System;
using System.Linq;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string favoriteNumber = "";
            int favNumberValue;
            string favoriteAnimal;
            bool valid = false;

            // Get first and last name from user input
            Console.WriteLine("Please input your First Name");
            firstName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please input your Last Name");
            lastName = Console.ReadLine();
            Console.Clear();

            // Get their favorite number
            while (!valid)
            {
                Console.WriteLine("Please input your Favorite Number");
                favoriteNumber = Console.ReadLine();
                valid = !string.IsNullOrWhiteSpace(favoriteNumber) &&
                        favoriteNumber.All(letter => letter >= '0' && letter <= '9');

                if (!valid)
                {
                    Console.WriteLine("Please input a number.");
                }
            }
            favNumberValue = Convert.ToInt32(favoriteNumber);
            Console.Clear();

            // Get their favorite animal
            Console.WriteLine("Please input your Favorite Animal");
            favoriteAnimal = Console.ReadLine();
            Console.Clear();

            // Once you have gotten all their info and stored it, display it back to them.
            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
            if (favNumberValue > 10)
            {
                Console.WriteLine($"From the provided data you have sent me your name is {firstName} {lastName}.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your favorite number is {favoriteNumber}.");
                Console.ResetColor();
                Console.WriteLine($"and your favorite animal is a {favoriteAnimal}.");
            }
            else if (favNumberValue < 5)
            {
                Console.WriteLine($"From the provided data you have sent me your name is {firstName} {lastName}.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your favorite number is {favoriteNumber}.");
                Console.ResetColor();
                Console.WriteLine($"and your favorite animal is a {favoriteAnimal}.");
            }
            else
            {
                Console.WriteLine($"From the provided data you have sent me your name is {firstName} {lastName}.");
                Console.WriteLine($"Your favorite number is {favoriteNumber}.");
                Console.WriteLine($"and your favorite animal is a {favoriteAnimal}.");
            }
        }
    }
}
