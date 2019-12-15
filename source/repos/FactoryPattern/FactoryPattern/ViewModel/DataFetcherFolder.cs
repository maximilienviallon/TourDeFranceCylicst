using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactoryPattern.ViewModel
{
    class DataFetcherFolder
    {
        
        List<Folder> listData = new List<Folder>();
      
         IModel something = FactoryModel.InstanciateConcreteClass(); 
        public List<Folder> fetchFolder()
        {
            string str = "";
            Folder f = new Folder(str);
            var directories = Directory.GetDirectories(@"C:\FactoryTest");
            foreach (string file in directories)
            {
               f.setName(file);
                listData.Add(f);
            }
            return listData;
        }

    }
}
