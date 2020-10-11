using System;

namespace Indivudella_uppgift
{
    internal class ViewSystem
    {
        private string _menu = "[1]Info about a Spacebody\n";

        private string _alternativeMenu = "No spaceBodies found...\n";

        private string input = "";

        private void ShowMenu()
        {
            if (PlayerSingleton.GetSpaceBodies().Count > 0)
            {
                string _spacebodies = showSpaceBodiesSeperatedByComma();
                Console.WriteLine("Showing Player's Spacebodies: \n" +
                    "{0}\n", _spacebodies);
                Console.WriteLine(_menu);
            }
            else
            {
                Console.WriteLine(_alternativeMenu);
            }
        }

        public void Menu()
        {
            ShowMenu();
            if (PlayerSingleton.GetSpaceBodies().Count == 0) return; // Returns back to main menu if no SpaceBodies in PlayerSingleton can be found, placed this first to skip an if/else
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Write name of SpaceBody you wish to inspect");

                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        private static string showSpaceBodiesSeperatedByComma()
        {
            string _spacebodies = "";

            foreach (SpaceBody spaceBody in PlayerSingleton.GetSpaceBodies())
            {
                _spacebodies += spaceBody.getName() + ", ";
            }
            _spacebodies = _spacebodies.Remove(_spacebodies.Length - 2);
            return _spacebodies;
        }

        private void showSpaceBodiesInList()
        {
            int index = 0;
            foreach (SpaceBody spaceBody in PlayerSingleton.GetSpaceBodies())
            {
                Console.WriteLine("[{0}] {1}", index++, spaceBody.getName());
            }
        }
    }
}