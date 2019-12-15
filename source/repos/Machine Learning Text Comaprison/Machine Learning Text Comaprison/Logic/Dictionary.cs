using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Learning_Text_Comaprison
{
    class Dictionary
    {
        

        public List<string> dictionary()
        {
            
            List<string> dictionary = new List<string>();

            List<string> allWords = TextFileParser("C:\\Users\\CptWubble\\Desktop\\New folder (3)");
            
           
            foreach  (string words in allWords)
            {
                string lwords = words.ToLower();
                allWords = lwords.Split(' ').ToList();

                foreach (string word in allWords)
                {
                    StringBuilder removingPunct = new StringBuilder();
                    foreach (char ch in word)
                    {
                        
                        if (!char.IsPunctuation(ch) && !char.IsSymbol(ch))
                        {   
                            removingPunct.Append(ch);
                        }
                    }
                    if (!dictionary.Contains(removingPunct.ToString()))
                    dictionary.Add(removingPunct.ToString());
                    
                }
            }

            return dictionary; 
        }
        public List<string> FolderReader(string filePath)
        {
            List<string> folder = new List<string>();
            string[] folderStringArray = Directory.GetDirectories(filePath);
            foreach (string folderName in folderStringArray)
            {
                string[] filesInFolder = Directory.GetFiles(folderName);
                foreach ( string fileName in filesInFolder)
                {
                    folder.Add(fileName);
                }
            }
            return folder;
        }

        public List<string> TextFileParser(string filePath)
        {
            List<string> allFiles = FolderReader(filePath);
            List<string> allWords = new List<string>();
            foreach (string files in allFiles)
            {
               allWords.Add(File.ReadAllText(files));
            }

            return allWords;
        }

    }
}
