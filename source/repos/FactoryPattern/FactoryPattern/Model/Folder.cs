using FactoryPattern.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    class Folder : IModel
    {
        
        private string name;
        List<string>  dataList= new List<string>();

        public Folder()
        {

        }
        public Folder(string Name)
        {
            this.name = getName();
            List<String> DataList = new List<string>();
            DataList.Add(Name);
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
