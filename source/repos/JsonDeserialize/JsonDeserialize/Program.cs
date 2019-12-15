using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonWeather = @"{'coord':{'lon':-0.13,'lat':51.51},'weather':[{'id':300,'main':'Drizzle','description':'light intensity drizzle','icon':'09d'}],'base':'stations','main':{'temp':280.32,'pressure':1012,'humidity':81,'temp_min':279.15,'temp_max':281.15},'visibility':10000,'wind':{'speed':4.1,'deg':80},'clouds':{'all':90},'dt':1485789600,'sys':{'type':1,'id':5091,'message':0.0103,'country':'GB','sunrise':1485762037,'sunset':1485794875},'id':2643743,'name':'London','cod':200}";
            JObject jw = JObject.Parse(jsonWeather);
            string idValue = (string)jw[0]["id"];
            Console.WriteLine(idValue);
            Console.ReadLine();
        }
    }
}
