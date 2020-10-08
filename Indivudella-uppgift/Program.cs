using System;

namespace Indivudella_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";
            do
            {
                input = Console.ReadLine();
                Console.WriteLine("User wrote: {0}", input);
            } while (input.ToLower() != "quit");

            Console.WriteLine("Goodbye");
        }
    }
}
