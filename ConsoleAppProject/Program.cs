
    using ConsoleAppProject.App01;
    using ConsoleAppProject.App02;
    using ConsoleAppProject.Helpers;
    using System;

    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Akes Ali 05/02/2022
    /// </summary>
    /// 
    namespace ConsoleAppProject
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                //Main header output
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine();
                Console.WriteLine(" ================================================= ");
                Console.WriteLine("    BNU CO453 Applications Programming 2021-2022  ");
                Console.WriteLine(" ================================================= ");
                Console.WriteLine();

                //selecter for different apps
                string[] choices =
                {
                " Distance Converter",
                " BMI Calculator",
            };

                Console.WriteLine(" Which Application would you like to use ?");
                Console.WriteLine();

                int choice = ConsoleHelper.SelectChoice(choices);
                //if 1 run app 1 DistanceConverter if 2 run app 2 BMICalculator
                switch (choice)
                {
                    case 1:
                        DistanceConverter converter = new DistanceConverter();
                        converter.Run();
                        break;
                    case 2:
                        BMICalculator app02 = new BMICalculator();
                        app02.Run();
                        break;
                    default:
                        break;
                }
            }
        }
    }