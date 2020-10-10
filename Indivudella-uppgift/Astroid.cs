namespace Indivudella_uppgift
{
    internal class Astroid : SpaceBody
    {
        public Astroid(string type, string name, float price, string[] resources) : base(type, name, price, resources: resources)
        {
        }

        public override void GenerateIncome()
        {
            float income = 0;
            for(int i = 0; i < resources.Length; i++)
            {
                income += 50;
            }
            PlayerSingleton.AddMoney(income);
        }
    }
}