namespace Indivudella_uppgift
{
    internal class Planet : SpaceBody
    {
        public Planet(string type, string name, float price, int population, string[] resources) : base(type, name, price, population: population, resources: resources)
        {
        }

        public override void GenerateIncome()
        {

        }
    }
}