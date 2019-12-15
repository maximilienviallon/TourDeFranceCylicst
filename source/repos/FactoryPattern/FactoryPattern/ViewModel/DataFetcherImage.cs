using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ViewModel
{
    class DataFetcherImage
    {
        public List<Image> fetchtxtData()
        {

            List<Image> dataList = new List<Image>();
            FactoryModel.InstanciateConcreteClass();
            DirectoryInfo d = new DirectoryInfo(@"C:\FactoryTest");
            FileInfo[] Files = d.GetFiles("*.png");
            string str;
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                

            }
            return dataList;
        }
    }
}
