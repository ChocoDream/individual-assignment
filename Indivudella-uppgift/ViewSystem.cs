using System;

namespace Indivudella_uppgift
{
    internal class ViewSystem
    {
        private string _menu = "[1]Info about a Spacebody\n" +
            "[2]Upgrade a Spacebody\n";

        private string _alternativeMenu = "No spaceBodies found...\n";

        private string input = "";

        private void ShowMenu()
        {
            if (PlayerSingleton.GetSpaceBodies().Count > 0)
            {
                string _spacebodies = "";

                foreach (SpaceBody spaceBody in PlayerSingleton.GetSpaceBodies())
                {
                    _spacebodies += spaceBody.getName() + ", ";
                }
                _spacebodies = _spacebodies.Remove(_spacebodies.Length - 2);
                Console.WriteLine("Showing Player's Spacebodies: \n" +
                    "{0}\n", _spacebodies);
                Console.WriteLine(_menu);
            } else
            {
                Console.WriteLine(_alternativeMenu);
            }
        }

        public void Menu()
        {
            ShowMenu();
        }
    }
}