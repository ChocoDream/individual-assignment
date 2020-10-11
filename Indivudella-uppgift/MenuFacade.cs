using System;

namespace Indivudella_uppgift
{
    internal class MenuFacade
    {
        private string _menu
            = "[1]Open planetStore\n" +
                "[2]View Planets\n" +
                "[3]End Turn\n" +
                "[5]Quit\n";

        public MenuFacade()
        {
        }

        public void MainMenu()
        {
            ShopSystem shop = new ShopSystem();
            ViewSystem view = new ViewSystem();
            TurnSystem turn = new TurnSystem();
            bool isRunning = true;
            string input = "";
            do
            {
                PlayerSingleton.CheckCurrency();
                Console.WriteLine(_menu);
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        shop.Menu();
                        break;

                    case "2":
                        view.Menu();
                        break;

                    case "3":
                        turn.nextTurn();
                        break;

                    case "5":
                        isRunning = false;
                        break;
                }
            } while (isRunning);
        }
    }
}