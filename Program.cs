using System;

namespace HelloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user to enter their name
            Console.Write("Please enter your full name:");

            // Beginning of try statement
            try
            {
                // Takes the user's input and assigns it to the string "name"
                string name = Console.ReadLine();

                // Displays a welcome message, "Hello (name)!"
                Console.WriteLine("Hello " + name + "!");

                // Prompts the user to press a key to exit the program
                Console.WriteLine("Press any key to exit the program.");

                // Ends the program after the user presses any key
                Console.ReadKey(true);
            }
            // End of try statement

            // Beginning of catch statement, if user somehow enters invalid input
            catch
            {
                // Lets the user know that their input was invalid, and asks the user to press a key to exit the program
                Console.WriteLine("Invalid input! Press any key to exit the program and try again.");

                // Ends the program after the user presses any key
                Console.ReadKey(true);
            }
            // End of catch
        }
    }
}
