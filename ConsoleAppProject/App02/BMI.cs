using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResult = 0;

        public string[] MenuChoices = { METRIC, IMPERIAL };

        public void OutputUnits()
        {
            Console.WriteLine("Please choose between the following: ");
            ConsoleHelper.OutputMenu(MenuChoices);
        }
        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the weight in KG:");
            }
            else
            {
                Console.WriteLine("Please enter the weight in Stone: ");
                Console.WriteLine("Please enter the weight in Pounds: ");
            }
            weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the height in CM:");
            }
            else
            {
                Console.WriteLine("Please enter the height in Feet:");
                Console.WriteLine("Please enter the height in Inches:");
            }
            height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        public void CalculateBMI()
        {
            if(SelectedUnit == METRIC)
            {
                bmiResult = (weight / height / height) * 10000;
            }
            bmiResult = Math.Floor(bmiResult);
        }
    }
}
