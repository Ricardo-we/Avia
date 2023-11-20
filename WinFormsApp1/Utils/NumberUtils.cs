using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaApp.Utils
{
    public class NumberUtils
    {
        public static double parseDouble(string value)
        {
            double parsedValue = 0;
            double.TryParse(value, out parsedValue);
            return parsedValue;
        }

        public static int parseInt(string value)
        {
            int parsedValue = 0;
            int.TryParse(value, out parsedValue);
            return parsedValue;
        }
    }
}
