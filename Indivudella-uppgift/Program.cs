using System;

namespace Indivudella_uppgift
{
    class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            MainMenuFacade mainMenu;
            do
            {
                mainMenu = new MainMenuFacade(Console.ReadLine());
                mainMenu.Operation();
            } while (isRunning);
        }
    }
}
