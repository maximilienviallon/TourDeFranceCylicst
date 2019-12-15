using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine_Learning_Text_Comaprison
{
    class KNNTest
    {
        Vectors importingAllVectors = new Vectors();
        public List<double> knnThingyForNow() 
        {
            int i = 0;
            List<List<int>> allTheVectors = importingAllVectors.vectorMaker();     
            List<int> unknownVector = allTheVectors[10];
            List<double> distanceList = new List<double>();               
                foreach (List<int> singleVector in allTheVectors)
                {
                    i++;
                    int j = 0;
                    double total = 0;
                    foreach (int wordValue in singleVector)
                    {   
                        
                        total = total + Math.Pow(unknownVector[j] - wordValue ,2);
                        j++;
                    }
                   // total = Math.Sqrt(total);
                    distanceList.Add(total);
                if (i > 9)
                {
                    break;
                }
                }
                distanceList.ForEach(Console.WriteLine);
            
            return distanceList; 
        }

        public string selectingK(int k)
        {
            List<double> distanceList = knnThingyForNow();
            List<double> distanceOfCarTexts = new List<double>();
            List<double> distanceOfMusicTexts = new List<double>();
            List<string> whichClassDoesItBelongToList = new List<string>();
            string whichClassDoesItBelongTo;
            int i = 0;
            foreach (double distance in distanceList)
            {
                if (i < 5)
                {
                    distanceOfCarTexts.Add(distance);
                }
                else if (i > 4 && i < 10)
                {
                    distanceOfMusicTexts.Add(distance);
                }
                i++;
            }
            int j = 0;
            while (j < k)
            {
                if(distanceOfCarTexts[j] > distanceOfMusicTexts[j])
                {
                    whichClassDoesItBelongToList.Add("music");
                }
                else
                {
                    whichClassDoesItBelongToList.Add("car");
                }
                j++;
            }
            int music = 0;
            int car = 0;
            foreach (string category in whichClassDoesItBelongToList)
            {
                if (category.Equals("music"))
                {
                    music++;
                }
                else
                {
                    car++;
                }
            }
            if(music> car)
            {
                whichClassDoesItBelongTo = "music";

            }
            else
            {
                whichClassDoesItBelongTo = "car";
            }
            return whichClassDoesItBelongTo;
        }
    }
}
