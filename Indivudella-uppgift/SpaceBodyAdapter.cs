namespace Indivudella_uppgift
{
    internal class SpaceBodyAdapter : ITarget
    {
        private readonly string spaceBodyName;

        public SpaceBodyAdapter(string spaceBodyName)
        {
            this.spaceBodyName = spaceBodyName;
        }

        public int Convert()
        {
            int idx = 0;
            bool foundItem = false;
            foreach (SpaceBody spaceBody in PlayerSingleton.GetSpaceBodies())
            {
                if (spaceBody.getName().Equals(spaceBodyName))
                {
                    foundItem = true;
                    break;
                }
                else
                {
                    idx++;
                }
            }
            return foundItem ? idx : -1;
        }
    }
}