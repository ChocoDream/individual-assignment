using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    static class SpaceBodyFactory
    {

        public static SpaceBody MakeSpaceBody(string type, string name, float price, string[] resources, int population = 0)
        {
            switch (type.ToLower())
            {
                case "planet":
                    return new Planet(type, name, price, resources: resources, population: population);
                case "asteroid":
                    return new Asteroid(type, name, price, resources: resources);
                default:
                    return null;
            }
        }
    }
}
