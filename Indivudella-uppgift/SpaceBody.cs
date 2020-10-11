using System;

namespace Indivudella_uppgift
{
    abstract class SpaceBody : ISpaceBody
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

        public abstract void GenerateIncome();

        public virtual string getType()
        {
            return type;
        }

        public virtual string getName()
        {
            return name;
        }

        public virtual float getPrice()
        {
            return price;
        }

        public virtual string[] getResources()
        {
            return resources;
        }

        public virtual int getPopulation()
        {
            return population;
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

        public virtual string toString()
        {
            string _resources = "";
            foreach (string resource in resources)
            {
                _resources += resource + ", ";
            }
            _resources = _resources.Remove(_resources.Length - 2);
            return string.Format(
                "Type: {0} Name: {1} Price: {2} population: {3} \n" +
                "Resources: {4}\n", type, name, price, population, _resources);
        }
    }
}