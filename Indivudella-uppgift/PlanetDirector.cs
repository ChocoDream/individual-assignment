using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class PlanetDirector
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }


        //Using Director to make default prefabs of planets

    }
}
