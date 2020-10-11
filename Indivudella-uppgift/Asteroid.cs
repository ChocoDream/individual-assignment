namespace Indivudella_uppgift
{
    internal class Asteroid : SpaceBody
    {
        public Asteroid(string type, string name, float price, string[] resources) : base(type, name, price, resources: resources)
        {
        }

        public override void GenerateIncome()
        {
            float income = 0;
            for (int i = 0; i < resources.Length; i++)
            {
                income += 100;
            }
            PlayerSingleton.AddMoney(income);
        }

        public override string toString()
        {
            string _resources = "";
            foreach (string resource in resources)
            {
                _resources += (resource + ", ");
            }
            _resources = _resources.Remove(_resources.Length - 2);
            return string.Format(
                "Type: {0} Name: {1} Price: {2} \n" +
                "Resources: {3}\n", type, name, price, _resources);
        }
    }
}