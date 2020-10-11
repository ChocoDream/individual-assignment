namespace Indivudella_uppgift
{
    internal class Planet : SpaceBody
    {
        public Planet(string type, string name, float price, int population, string[] resources) : base(type, name, price, population: population, resources: resources)
        {
        }

        public override void GenerateIncome()
        {
            float incomePerPerson = 12.5f;
            float income = (population * incomePerPerson);
            for (int i = 0; i < resources.Length; i++)
            {
                income += 80;
            }
            PlayerSingleton.AddMoney(income);
        }
    }
}