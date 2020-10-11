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

        public static double GetMoney()
        {
            return money;
        }

        public static PlayerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PlayerSingleton();
            }
            return _instance;
        }

        public static bool IsBankrupt()
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
            System.Console.WriteLine("Player's Money: {0}", money);
        }

        public static List<SpaceBody> GetSpaceBodies()
        {
            return spaceBodies;
        }

        public static void AddSpaceBody(SpaceBody spaceBody)
        {
            spaceBodies.Add(spaceBody);
        }
    }
}