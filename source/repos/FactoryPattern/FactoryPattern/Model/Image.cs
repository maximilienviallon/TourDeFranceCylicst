using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    class Image : IModel
    {
        private string name;


        public Image()
        {

        }
        public Image(string Name)
        {
            this.name = Name;

        }

        public string getName()
        {
            return name;
        }

        public void setName(string Name)
        {
            this.name = Name;
        }


    }
}
