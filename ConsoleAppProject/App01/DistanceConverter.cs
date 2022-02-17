using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        private double toDistance;

        private double fromDistance;

        private string toDistance;

        private string fromDistance;
        /// <summary>
        /// This runs the program
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputToUnit();
            InputFromUnit();

            Console.WriteLine("To unit is : " + toUnit);
            Console.WriteLine("From unit is " + fromUnit);



            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void EnterUnit()
        {
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("Miles");

            fromDistance = Console.ReadLine();
        }

        private void InputToUnit()
        {
            Console.WriteLine("Enter the ToUnit");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("Miles");

            fromDistance = Console.ReadLine();
        }

        private void InputFromUnit()
        {
            Console.WriteLine("Enter the fromUnit");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("Miles");

            fromDistance = Console.ReadLine();
        }

        private void ConvertMilestoFeet()
        {
            feet = miles * 5280;
        }

        private void Convert()
        {
            if(InputFromUnit().Contains("Feet",StringComparison.CurrentCultureIgnoreCase)
                && toUnit.Contains("Feet"))
            {
                fromDistance
            }
        }
        /// <summary>
        /// Prompts the user to enter a value for miles
        /// </summary>
        private void InputMiles()
        {

        }

        private void InputUnit()
        {
            Console.Write("Please enter the distance in " + fromDistance + " > ");

        }
        /// <summary>
        /// Calculates 
        /// </summary>
        private void CalculateFeet()
        {

        }

        private void OutputFeet()
        {

        }
    }
}
