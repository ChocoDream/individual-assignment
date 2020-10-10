using System;

namespace Indivudella_uppgift
{
    public class ShopSystem
    {
        private string _menu = "[1]Buy Spacebody\n" +
            "[2]Sell Spacebody\n";

        private SpaceBody[] storeSpaceBodies = new SpaceBody[] {
             SpaceBodyFactory.MakeSpaceBody(type: "Planet", name: "Lazytown", 500, population: 2000, resources: new string[] {"Robbie Rotten", "Pranks", "Laziness"}),
             SpaceBodyFactory.MakeSpaceBody(type: "Asteroid", name: "Minecraftiod", 60, resources: new string[] {"Creepers", "Gunpowder", "Diamonds", "Iron", "Ghasts"}),
             SpaceBodyFactory.MakeSpaceBody(type: "Asteroid", name: "Terrarium", 60, resources: new string[] {"Metroidite", "Copper", "Steel", "Magmanite", "Demons"}),
             SpaceBodyFactory.MakeSpaceBody(type: "Planet", name: "Earth", 2500, population: 20000, resources: new string[] {"Dirt", "Magma", "Water", "Iron", "Humans"}),
             SpaceBodyFactory.MakeSpaceBody(type: "Planet", name: "Mars", 5000, population: 20, resources: new string[] {"Edun Musk", "Rocks", "Aliens"})
        };

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
            for (int i = 0; i < storeSpaceBodies.Length; i++)
            {
                Console.WriteLine("[{0}] {1}", i, storeSpaceBodies[i].toString());
            }
            PlayerSingleton.CheckCurrency();
            Console.WriteLine("Write what you want to buy");
        }

        private void Sell()
        {
            if (PlayerSingleton.getSpaceBodies().Count == 0)
            {
                Console.WriteLine("You got nothing to sell");
                return;
            };
        }
    }
}