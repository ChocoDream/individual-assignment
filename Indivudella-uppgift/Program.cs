using System;

namespace Indivudella_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";
            String menu =
                "[1]Buy Planet\n" +
                "[2]Sell Planet\n" +
                "[3]View Planets\n" +
                "[4]End Turn\n" +
                "[5]Quit\n";
            do
            {
                Console.WriteLine(menu);
                input = Console.ReadLine();
            } while (input != "5");
        }
    }
}
