using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDailyValueCalculator.Foods
{
    public class Food
    {
        public double Calories { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fiber { get; set; }
        public double Sugar { get; set; }
        public double VitaminC { get; set; }
        public double Calcium { get; set; }
        public double Iron { get; set; }

        public Food(double calories, double fats, double proteins, double carbohydrates, 
                    double fiber, double sugar, double vitaminc, double calcium, double iron)
        {
            Calories = calories;
            Fats = fats;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fiber = fiber;
            Sugar = sugar;
            VitaminC = vitaminc;
            Calcium = calcium;
            Iron = iron;

        }
    }
}
