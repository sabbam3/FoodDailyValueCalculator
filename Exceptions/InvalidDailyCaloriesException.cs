using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDailyValueCalculator.Exceptions
{
    public class InvalidDailyCaloriesException : Exception
    {
        public InvalidDailyCaloriesException(string message) : base(message)
        {
            
        }
        
    }
}
