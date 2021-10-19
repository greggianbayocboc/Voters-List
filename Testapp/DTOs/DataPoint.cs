using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gregg.DTOs
{
    public class DataPoint
    {
        public string Argument { get; set; }
        public double Value { get; set; }

        public static List<DataPoint> GetDataPoints()
        {
            return new List<DataPoint> {
                    new DataPoint { Argument = "Russia",    Value = 17.0752},
                    new DataPoint { Argument = "Canada",    Value = 9.98467},
                    new DataPoint { Argument = "USA",       Value = 9.63142},
                    new DataPoint { Argument = "China",     Value = 9.59696},
                    new DataPoint { Argument = "Brazil",    Value = 8.511965},
                    new DataPoint { Argument = "Australia", Value = 7.68685},
                    new DataPoint { Argument = "India",     Value = 3.28759},
                    new DataPoint { Argument = "Others",    Value = 81.2}
                };
        }
    }
}
