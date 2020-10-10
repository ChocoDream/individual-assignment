using System;

namespace Indivudella_uppgift
{
    public class ShopSystem
    {
        private string _menu = "[1]Buy Planet\n" +
            "[2]Sell Planet\n";

        private void ShowMenu()
        {
            Console.WriteLine(_menu);
        }

        public void Menu()
        {
            ShowMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Buy();
                    break;

                case "2":
                    Sell();
                    break;
            }
        }

        private void Buy()
        {
        }

        private void Sell()
        {
        }
    }
}