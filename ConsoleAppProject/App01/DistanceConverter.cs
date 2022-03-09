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
        public const double FEET_IN_Metres = 3.28084;
        public const double FEET_IN_CENTIMETRES = 30.48;
        public const double FEET_IN_KILOMETRES = 0.000305;
        public const int FEET_IN_INCHES = 12;

        public const double METRES_IN_FEET = 3.2808398950131;
        public const double METRES_IN_MILES = 0.00062137119223733;
        public const int METRES_IN_CENTIMETRES = 100;
        public const double METRES_IN_KILOMETRES = 0.001;
        public const double METRES_IN_INCHES = 39.37;

        public const int MILES_IN_FEET = 5280;
        public const double MILES_IN_METERS = 1609.344;
        public const double MILES_IN_CENTIMETRES = 160934.4;
        public const double MILES_IN_KILOMETRES = 1.609;
        public const int MILES_IN_INCHES = 63360;

        public const double CENTIMETRES_IN_FEET = 30.48;
        public const int CENTIMETRES_IN_METRES = 100;
        public const double CENTIMETRES_IN_MILES = 160934;
        public const int CENTIMETRES_IN_KILOMETRES = 100000;
        public const double CENTIMETRES_IN_INCHES = 0.394;

        public const double KILOMETRES_IN_FEET = 3280.8398950131;
        public const double KILOMETRES_IN_MILES = 0.62137119223733;
        public const int KILOMETRES_IN_METRES = 1000;
        public const int KILOMETRES_IN_CENTIMETRES = 100000;
        public const double KILOMETRES_IN_INCHES = 39370.078740157;

        public const double INCHES_IN_FEET = 0.083333333333333;
        public const int INCHES_IN_MILES = 63360;
        public const double INCHES_IN_METRES = 0.0254;
        public const double INCHES_IN_CENTIMETRES = 2.54;
        public const double INCHES_IN_KILOMETRES = 39370.078740157;


        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
        public const string CENTIMETRES = "Centimetres";
        public const string KILOMETRES = "Kilometres";
        public const string INCHES = "Inches";


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
                fromDistance = InputDistance("Please enter the number of {FromDistance} >");
                CalculateDistance();
                OutPutDistance(fromDistance, fromUnit, toDistance, toUnit);
        }

        public void CalculateDistance()
        {
            //FEET
            if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = FromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = FromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = FromDistance * FEET_IN_KILOMETRES;
            }
            else if (fromUnit == FEET && toUnit == CENTIMETRES)
            {
                toDistance = FromDistance * FEET_IN_CENTIMETRES;
            }
            else if (fromUnit == FEET && toUnit == INCHES)
            {
                toDistance = FromDistance * FEET_IN_INCHES;
            }
            //MILES
            else if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * MILES_IN_FEET;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * MILES_IN_METERS;
            }
            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * MILES_IN_KILOMETRES;
            }
            else if (fromUnit == MILES && toUnit == CENTIMETRES)
            {
                toDistance = fromDistance * MILES_IN_CENTIMETRES;
            }
            else if (fromUnit == MILES && toUnit == INCHES)
            {
                toDistance = fromDistance * MILES_IN_INCHES;
            }
            //METRES
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = FromDistance * METRES_IN_FEET;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = FromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = FromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == METRES && toUnit == CENTIMETRES)
            {
                toDistance = FromDistance * METRES_IN_CENTIMETRES;
            }
            else if (fromUnit == METRES && toUnit == INCHES)
            {
                toDistance = FromDistance * METRES_IN_INCHES;
            }
            //KILOMETRES
            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = FromDistance * KILOMETRES_IN_FEET;
            }
            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = FromDistance * KILOMETRES_IN_MILES;
            }
            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = FromDistance * KILOMETRES_IN_METRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == CENTIMETRES)
            {
                toDistance = FromDistance * KILOMETRES_IN_CENTIMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == INCHES)
            {
                toDistance = FromDistance * KILOMETRES_IN_INCHES;
            }
            //CENTIMETRES
            else if (fromUnit == CENTIMETRES && toUnit == FEET)
            {
                toDistance = FromDistance * CENTIMETRES_IN_FEET;
            }
            else if (fromUnit == CENTIMETRES && toUnit == MILES)
            {
                toDistance = FromDistance / CENTIMETRES_IN_MILES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == METRES)
            {
                toDistance = FromDistance * CENTIMETRES_IN_METRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == KILOMETRES)
            {
                toDistance = FromDistance / CENTIMETRES_IN_KILOMETRES;
            }
            else if (fromUnit == CENTIMETRES && toUnit == INCHES)
            {
                toDistance = FromDistance * CENTIMETRES_IN_INCHES;
            }
            //INCHES
            if (fromUnit == INCHES && toUnit == FEET)
            {
                toDistance = FromDistance * INCHES_IN_FEET;
            }
            if (fromUnit == INCHES && toUnit == MILES)
            {
                toDistance = FromDistance / INCHES_IN_MILES;
            }
            if (fromUnit == INCHES && toUnit == METRES)
            {
                toDistance = FromDistance * INCHES_IN_METRES;
            }
            if (fromUnit == INCHES && toUnit == KILOMETRES)
            {
                toDistance = FromDistance / INCHES_IN_KILOMETRES;
            }
            if (fromUnit == INCHES && toUnit == CENTIMETRES)
            {
                toDistance = FromDistance * INCHES_IN_CENTIMETRES;
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
            else if (choice.Equals("4"))
            {
                return CENTIMETRES;
            }
            else if (choice.Equals("5"))
            {
                return KILOMETRES;
            }
            else if (choice.Equals("6"))
            {
                return INCHES;
            }
            return null;
        }

        /// <summary>
        /// Display the options for the user to choose from
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            double selection = 1;
            bool inValid;

            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine($" 4. {CENTIMETRES}");
            Console.WriteLine($" 5. {KILOMETRES}");
            Console.WriteLine($" 6. {INCHES}");

            do
            {
                Console.WriteLine(prompt);
                string choice = Console.ReadLine();
                try
                {
                    selection = Convert.ToDouble(choice);
                    if (selection >= 1 && selection <= 6)
                    {
                        inValid = false;
                    }
                    else
                    {
                        inValid = true;
                        Console.WriteLine(" Selection out of range please try again ");
                    }
                }
                catch (Exception)
                {
                    inValid = true;
                    Console.WriteLine(" Incorrect format please try again ");
                }
            }while (inValid);

                return Convert.ToString(selection);
        }

        /// <summary>
        /// prompts the user to enter distance in miles
        /// </summary>
        private double InputDistance(string prompt)
        {
            double number = 0;
            bool isValid;
            do
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    if (number > 0)
                    {
                        isValid = false;
                    }
                    else
                    {
                        isValid = true;
                        Console.WriteLine(" Negative number invalid please try again ");
                    }
                }
                catch (Exception)
                {
                    isValid = true;
                    Console.WriteLine(" Invalid number please try again ");
                }

            } while (isValid);

            return Convert.ToDouble(number);
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