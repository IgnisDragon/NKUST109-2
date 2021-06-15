using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Model
{
    public class WaterConsumption
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int consumptionOfWater { get; set; } // ConsumptionOfWater(生活用水量，立方公尺)
        public string executingUnit { get; set; } // ExecutingUnit(縣市別)
        public float populationServed { get; set; } // PopulationServed(年中供水人數，人)
        public string remarks { get; set; } // Remarks(備註)
        public int theDailyDomesticConsumptionOfWaterPerPerson { get; set; } // TheDailyDomesticConsumptionOfWaterPerPerson(每人每日生活用水量，公升)
        public string year { get; set; } // Year(統計年度)
    }
}
