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
                Planet earth = new Planet(input);
                Console.WriteLine("Planet {0}", earth.name);
            } while (input.ToLower() != "quit");
        }
    }
}
