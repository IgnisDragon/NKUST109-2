using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using ConsoleApp1.Model;
using ConsoleApp1.Service;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // test
            WaterConsumption test = new WaterConsumption()
            {
                consumptionOfWater = 36685788,
                executingUnit = "宜蘭縣",
                populationServed = 421328,
                remarks = "無",
                theDailyDomesticConsumptionOfWaterPerPerson = 238,
                year = "2008-12-31T00:00:00"
            };

            // 序列化
            //string jsonData = JsonConvert.SerializeObject(test);
            //Console.WriteLine(jsonData);

            List<WaterConsumption> results = new ImportJsonService().read(@"..\..\..\7D1311DD-E1DE-4B01-A5ED-1FC589A7C082.json");

            Console.WriteLine(String.Format("全部共有{0}筆資料\n", results.Count));

            foreach (WaterConsumption result in results)
            {
                Console.WriteLine("ConsumptionOfWater:" + result.consumptionOfWater);
                Console.WriteLine("ExecutingUnit:" + result.executingUnit);
                Console.WriteLine("PopulationServed:" + result.populationServed);
                Console.WriteLine("Remarks:" + result.remarks);
                Console.WriteLine("TheDailyDomesticConsumptionOfWaterPerPerson:" + result.theDailyDomesticConsumptionOfWaterPerPerson);
                Console.WriteLine("Year:" + result.year);
                Console.WriteLine("");
            }
        }
    }
}