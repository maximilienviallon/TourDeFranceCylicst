using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    class Text : IModel
    {
        string name;

        public Text()
        {

        }
        public Text(string Name)
        {
            this.name = Name;


        }

        public string getName()
        {
            return name;
        }

        public void setName(string Name)
        {
            Name = this.name;
        }

    }
}