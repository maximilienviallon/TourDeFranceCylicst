using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Model
{
    class FactoryModel : IModel
    {
        private List<string> ListData = new List<string>();
        private static string name = " ";
        private static IModel model;
        public static IModel InstanciateConcreteClass()
        {
           if(name.Contains(".txt"))
            {
                model = new Text();


            }
           else if(name.Contains(".png"))
            {
                model = new Image();

            }
            else
            {
                model = new Folder(name);

            }
            return model;
        }

    // method creates List<String> with the appropriate data
         public List<string> gatherData(string Data)
        {

            return ListData;
        }
        public List<string> StoreData()
        {

            return ListData;
        }
       
        public string getName()
        {
            return name;
        }

        public void setName(string Name)
        {
            name = Name;
        }

        public List<string> getList()
        {
            return ListData;
        }
    }
}
