using System;

namespace Indivudella_uppgift
{
    internal class TurnSystem
    {
        public void nextTurn()
        {
            foreach (SpaceBody spacebody in PlayerSingleton.GetSpaceBodies())
            {
                spacebody.GenerateIncome();
            }
        }
    }
}