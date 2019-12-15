using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ViewModel
{
    class dataFetcher
    {
      public List<Text> fetchtxtData()
        {
            List<Text> dataList = new List<Text>();
            DirectoryInfo d = new DirectoryInfo(@"C:\FactoryTest");
            FileInfo[] Files = d.GetFiles("*.txt");
            string str;
            foreach (FileInfo file in Files)
            {
                str = file.Name;
               // FactoryModel.InstanciateConcreteClass(str);
                
            }
            return dataList;
        }

    }
}
