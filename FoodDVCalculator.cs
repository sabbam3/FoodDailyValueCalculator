using FoodDailyValueCalculator.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDailyValueCalculator.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace FoodDailyValueCalculator
{
    public class FoodDVCalculator
    {
        private Food _food;
        private double _dailyCalories;
        public DailyValue Calculate(Food food, double dailyCalories)
        {
            if (dailyCalories == 0)
            {
                throw new InvalidDailyCaloriesException("Invalid Parameters");
            }
            _food = food;
            _dailyCalories = dailyCalories;
            return new DailyValue
            {
                Calories = CalculateCalories(),
                Fats = CalculateFats(),
                Proteins = CalculateProteins(),
                Carbohydrates = CalculateCarbohydrates(),
                Fiber = CalculateFiber(),
                Sugar = CalculateSugar(),
                VitaminC = CalculateVitaminC(),
                Calcium = CalculateCalcium(),
                Iron = CalculateIron(),
            };
        }

        private double CalculateIron()
        {
            var dailyIronValue = FoodConstants.IronPerCalorie * _dailyCalories;
            return _food.Iron / dailyIronValue;
        }

        private double CalculateCalcium()
        {
            var dailyCalciumValue = FoodConstants.CalciumPerCalorie * _dailyCalories;
            return _food.Calcium / dailyCalciumValue;
        }

        private double CalculateVitaminC()
        {
            var dailyVitaminCValue = FoodConstants.VitaminCPerCalorie * _dailyCalories;
            return _food.VitaminC / dailyVitaminCValue;
        }

        private double CalculateSugar()
        {
            var dailySugarValue = FoodConstants.SugarPerCalorie * _dailyCalories;
            return _food.Sugar / dailySugarValue;
        }

        private double CalculateFiber()
        {
            var dailyFiberValue = FoodConstants.FiberPerCalorie * _dailyCalories;
            return _food.Fiber / dailyFiberValue;
        }

        private double CalculateCarbohydrates()
        {
            var dailyCarbohydratesValue = FoodConstants.CarbohydratePerCalorie * _dailyCalories;
            return _food.Carbohydrates / dailyCarbohydratesValue;
        }

        private double CalculateProteins()
        {
            var dailyProteinsValue = FoodConstants.ProteinPerCalorie * _dailyCalories;
            return _food.Proteins / dailyProteinsValue;
        }

        private double CalculateFats()
        {
            var dailyFatValue = FoodConstants.FatPerCalorie * _dailyCalories;
            return _food.Fats / dailyFatValue;
        }

        private double CalculateCalories()
        {
            return _food.Calories / _dailyCalories;
        }
    
    }
}
