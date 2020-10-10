using System;

namespace Indivudella_uppgift
{
    internal class SpaceBody : ISpaceBody
    {
        protected string name;
        protected string type;
        protected float price;
        protected int population;
        protected string[] resources;

        protected SpaceBody(string type, string name, float price, string[] resources, int population = 0)
        {
            this.type = type;
            this.name = name;
            this.price = price;
            this.resources = resources;
            this.population = population;
        }

        public virtual void GenerateIncome()
        {
        }

        public virtual void GetInformation()
        {
            string _resources = "";
            foreach (string resource in resources)
            {
                _resources += resource;
            }
            string information = string.Format("Information on {1}" +
                "type: {0}\n" +
                "name: {1}\n" +
                "price: {2}\n" +
                "population: {3}\n" +
                "resources: {4}\n", type, name, price, population, _resources);

            Console.WriteLine(information);
        }
    }
}