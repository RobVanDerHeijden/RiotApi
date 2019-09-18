using System;

namespace ConsoleApp
{
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int value = 10;
            // Variable
            Console.WriteLine(value);
            // Literal
            Console.WriteLine(50.05);
            Console.WriteLine("Value = " + value);

            string testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
