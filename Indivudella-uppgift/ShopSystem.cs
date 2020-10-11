using System;

namespace Indivudella_uppgift
{
    public class ShopSystem
    {
        private string _menu = "[1]Buy Spacebody\n" +
            "[2]Sell Spacebody\n";

        private SpaceBody[] storeSpaceBodies = new SpaceBody[] {
             SpaceBodyFactory.MakeSpaceBody(Type: SpaceBodyFactory.TYPE.PLANET, name: "Lazytown", 500, population: 20, resources: new string[] {"Robbie Rotten", "Pranks", "Laziness"}),
             SpaceBodyFactory.MakeSpaceBody(Type: SpaceBodyFactory.TYPE.ASTEROID, name: "Minecraftiod", 60, resources: new string[] {"Creepers", "Gunpowder", "Diamonds", "Iron", "Ghasts"}),
             SpaceBodyFactory.MakeSpaceBody(Type: SpaceBodyFactory.TYPE.ASTEROID, name: "Terrarium", 60, resources: new string[] {"Metroidite", "Copper", "Steel", "Magmanite", "Demons"}),
             SpaceBodyFactory.MakeSpaceBody(Type: SpaceBodyFactory.TYPE.PLANET, name: "Earth", 2500, population: 20000, resources: new string[] {"Dirt", "Magma", "Water", "Iron", "Humans"}),
             SpaceBodyFactory.MakeSpaceBody(Type: SpaceBodyFactory.TYPE.PLANET, name: "Mars", 5000, population: 20, resources: new string[] {"Edun Musk", "Rocks", "Aliens"})
        };

        private string input = "";

        private void ShowMenu()
        {
            Console.WriteLine(_menu);
        }

        public void Menu()
        {
            ShowMenu();
            input = Console.ReadLine();
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
            input = Console.ReadLine();
            if (int.TryParse(input, out int option))
            {
                if (storeSpaceBodies.Length < option)
                {
                    Console.WriteLine("Doesn't exist");
                    return;
                }
                if (storeSpaceBodies[option].getPrice() > PlayerSingleton.GetMoney())
                {
                    Console.WriteLine("Can't afford");
                    return;
                }
                if (storeSpaceBodies[option].getPrice() <= PlayerSingleton.GetMoney())
                {
                    PlayerSingleton.AddSpaceBody(storeSpaceBodies[option]);
                }
            }
        }

        private void Sell()
        {
            if (PlayerSingleton.GetSpaceBodies().Count == 0)
            {
                Console.WriteLine("You got nothing to sell");
                return;
            };
        }
    }
}