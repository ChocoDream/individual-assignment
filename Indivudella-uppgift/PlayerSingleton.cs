using System.Collections.Generic;

namespace Indivudella_uppgift
{
    internal class PlayerSingleton
    {
        private PlayerSingleton()
        {
        }

        private static PlayerSingleton _instance;
        private static double money = 100;
        private static List<SpaceBody> spaceBodies = new List<SpaceBody>();

        public static PlayerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PlayerSingleton();
            }
            return _instance;
        }

        public static bool isBankrupt()
        {
            return money <= 0 ? true : false;
        }

        public static void AddMoney(float _money)
        {
            money += _money;
        }

        public static void Pay(float cost)
        {
            money -= cost;
        }

        public static void CheckCurrency()
        {
            System.Console.WriteLine("Player's Money: {0}\n", money);
        }

        public static List<SpaceBody> getSpaceBodies()
        {
            return spaceBodies;
        }
    }
}