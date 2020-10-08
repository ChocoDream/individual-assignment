namespace Indivudella_uppgift
{
    internal class PlanetBuilder : IBuilder
    {
        private Planet _planet = new Planet();

        public PlanetBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._planet = new Planet();
        }

        public void BuildShape()
        {

        }

        public void BuildColor()
        {

        }

        public void BuildHabitable()
        {

        }

        public Planet GetPlanet()
        {
            Planet result = this._planet;
            this.Reset();
            return result;
        }
    }
}