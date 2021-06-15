using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp1.Model;

namespace ConsoleApp1.Service
{
    public class ImportJsonService
    {
        public ImportJsonService() { }

        public List<WaterConsumption> read(String filePath)
        {
            //反序列化
            string jsontext = File.ReadAllText(filePath);
            // "..\..\..\7D1311DD-E1DE-4B01-A5ED-1FC589A7C082.json"

            JObject domesticConsumptionOfWater = JObject.Parse(jsontext);

            var consumption = domesticConsumptionOfWater["TaiwanWaterExchangingData"]["StatisticofWaterResourcesClass"]["TheDomesticConsumptionOfWater"].Children();

            // serialize JSON results into .NET objects
            List<WaterConsumption> results = new List<WaterConsumption>();

            foreach (JToken token in consumption)
            {
                WaterConsumption water = token.ToObject<WaterConsumption>();
                results.Add(water);
            }
            return results;
        }

    }
}
