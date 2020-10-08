using System;
using System.Collections.Generic;
using System.Text;

namespace Indivudella_uppgift
{
    class Planet
    {
        public string name
        { get; set; } = "default";
        private List<object> _properties = new List<object>();
        public Planet()
        {

        }
        public void Add(string property)
        {
            this._properties.Add(property);
        }

        public void listProperties()
        {
            string str = string.Empty;

        }
    }
}
