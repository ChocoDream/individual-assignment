using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    static class SpaceBodyFactory
    {
        public enum TYPE{
            PLANET,
            ASTEROID
        }

        public static SpaceBody MakeSpaceBody(TYPE Type, string name, float price, string[] resources, int population = 0)
        {
            string type = "";
            switch (Type)
            {
                case TYPE.PLANET:
                    type = "planet";
                    return new Planet(type, name, price, resources: resources, population: population);
                case TYPE.ASTEROID:
                    type = "asteroid";
                    return new Asteroid(type, name, price, resources: resources);
                default:
                    return null;
            }
        }
    }
}
