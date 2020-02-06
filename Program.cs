using System;

namespace HelloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your full name:");

            try
            {
                string name = Console.ReadLine();

                Console.WriteLine("Hello " + name + "!");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Invalid input! Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
        }
    }
}
