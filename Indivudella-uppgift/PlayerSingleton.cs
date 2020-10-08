using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class PlayerSingleton
    {
        private PlayerSingleton() { }
        private static PlayerSingleton _instance;
        private int money = 100;

        public static PlayerSingleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new PlayerSingleton();
            }
            return _instance;
        }
    }
}
