using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Akes version 0.1
    /// </author>
    public class DistanceConverter
    {
        public void Run ()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.ConverterDistance();
        }
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_Metres = 3.28084;


        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";


        private double toDistance;
        private double fromDistance;

        private string fromUnit;
        private string toUnit;

        public double FromDistance { get; private set; }
        public double FEET_IN_METRES { get; private set; }

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        ///<summary>
        /// this inputs the distance into the correct units
        /// </summary>
        public void ConverterDistance()
        {
            OutputHeading();
            do
            {
                fromUnit = SelectUnit("Please select from distance unit>");
            } while (fromUnit == null);
            do
            {
                toUnit = SelectUnit("please select to distance unit>");
            }while (toUnit == null);

                Console.WriteLine($" Converting {fromUnit} to {toUnit}");
                fromDistance = InputDistance("Please enter the number of {fromDsitance} >");
                CalculateDistance();
                OutPutDistance(fromDistance, fromUnit, toDistance, toUnit);
            }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        /// <summary>
        /// Display the options for the user to choose from
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// prompts the user to enter distance in miles
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Display the distance entered
        /// </summary>
        private void OutPutDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}!");
        }

        private void OutputHeading()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("     Distance Converter     ");
            Console.WriteLine("            by AK              ");
            Console.WriteLine("-----------------------------------");
        }
    }
}