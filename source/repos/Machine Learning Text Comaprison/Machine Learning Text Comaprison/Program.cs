using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Learning_Text_Comaprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Dictionary d = new Dictionary();
            /*string[] wordArray;
            string something = d.TextFileParser("C:\\Users\\CptWubble\\Desktop\\New folder (3)");
            wordArray = something.Split(' ');

            int i = 0;

            foreach (string words in wordArray)
            {
                Console.WriteLine(words);
               i++;
            }


           List<string> folders = d.FolderReader("C:\\Users\\CptWubble\\Desktop\\New folder (3)");
           foreach  (string names in folders)
           {
               Console.WriteLine(names);
           }
           //Console.WriteLine(i);
            



            int j = 0;
            List<string> allDictionaryWords = d.dictionary();
            foreach  (string words in allDictionaryWords)
            {
                Console.WriteLine(words);
                j++;
            }
            Console.WriteLine(j);*/

            /*int i = 0;
            Vectors vec = new Vectors();
            List<List<int>> allVec = vec.vectorMaker();
            foreach (List<int> singleVec in allVec)
            {
                foreach (int vecEl in singleVec)
                {
                    Console.WriteLine(vecEl);
                    i++;
                }
            }
            Console.WriteLine(i);
            */

            KNNTest knn = new KNNTest();
            //knn.knnThingyForNow();
            Console.WriteLine(knn.selectingK(1));
            Console.ReadLine();

           
        }
    }
}
