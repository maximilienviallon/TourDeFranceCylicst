using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeFranceCyclist
{
    

    class Cyclist
    {
        private string name;
        private string gender;
        private string countryOfOg;
        private string resultTime;
        private string endPosition;
        public Cyclist(string name, string gender, string country, string result, string endPos)
        {
            this.name = name;
            this.gender = gender;
            this.countryOfOg = country;
            this.resultTime = result;
            this.endPosition = endPos;
        }

    }


}
