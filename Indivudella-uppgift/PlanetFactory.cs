using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class PlanetFactory
    {

        public SpaceBody MakeSpaceBody(string type, string name, float price, int population, string[] resources)
        {
            switch (type)
            {
                case "planet":
                    return new Planet(type, name, price, population, resources);
                default:
                    return null;
            }
        }
    }
}
