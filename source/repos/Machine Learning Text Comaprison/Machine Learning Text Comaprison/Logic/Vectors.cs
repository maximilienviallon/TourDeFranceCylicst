using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Learning_Text_Comaprison
{
    class Vectors
    {
        private Dictionary dictionaryClassImport = new Dictionary();
        public List<List<int>> vectorMaker()
        {
            List<List<int>> allVectors = new List<List<int>>();
            List<string> folderImport = dictionaryClassImport.FolderReader("C:\\Users\\CptWubble\\Desktop\\New folder (3)");
            List<string> dictionaryImport = dictionaryClassImport.dictionary();
            
            foreach (string filePath in folderImport)
            {
                List<int> vector = new List<int>();

                string something = File.ReadAllText(filePath);
                List<string> justOneFile = something.Split(' ').ToList();
                foreach (string word in justOneFile)
                { 
                    StringBuilder removingPunct = new StringBuilder();
                    foreach (char ch in word)
                    {
                        if (!char.IsPunctuation(ch) && !char.IsSymbol(ch))
                        {
                            removingPunct.Append(ch);
                        }
                    }
                }
                foreach (string dictWord in dictionaryImport)
                {
                    if (justOneFile.Contains(dictWord))
                    {
                        vector.Add(1);
                    }
                    else
                    {
                        vector.Add(0);
                    }
                }
                allVectors.Add(vector);
            }
            return allVectors;
        }
    }
}
