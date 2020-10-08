using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class PlayerSingleton
    {
        private PlayerSingleton() { }
        private static PlayerSingleton _instance;
        private static int money = 100;

        public static PlayerSingleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new PlayerSingleton();
            }
            return _instance;
        }
        public static int Money
        {
            get { return money; }
            set { money -= value; }
        }
    }
}
