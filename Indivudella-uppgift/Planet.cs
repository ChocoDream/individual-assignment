using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class Planet : SpaceBody
    {
        public Planet(string type, string name, float price, int population, string[] resources) : base(type, name, price, population, resources)
        {

        }

        public override void GenerateIncome()
        {
            base.GenerateIncome();
        }
    }
}
