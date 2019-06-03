using System;

// Namespace
namespace NumberGuesser
{   
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser(); // Ask for users name and greet

            while (true)
            {
                // Create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init user guess var
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10!");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    { 
                        PrintColorMessage(ConsoleColor.Red, "Enter a number! We're guessing numbers.. REMEMBER???");
                        continue;
                    }

                    // Cast int and set guess to input value
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    { 
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number... Try again...");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You got it!!");

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        // Get and display app info
        static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Michael Eckstine";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write App info
            Console.WriteLine("{0} - Version: {1} - By: {2}", appName, appVersion, appAuthor);

            // Resets text color
            Console.ResetColor();
        }
        // Get user name and greet
        static void GreetUser() {
            Console.WriteLine("What is your name?");

            // Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}, let's play a game", inputName);
        }
        // Print colored message
        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
