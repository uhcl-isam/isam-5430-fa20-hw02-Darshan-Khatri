using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>
    public class GasMileage
    {
        public static void Main()
        {
            int Mile = 0;
            int Gallon = 0;
            float MPG = 0;
            float SumMPG = 0;
            int GallonSum = 0;
            int MileSum = 0;

            while (true)
            {
                Console.Write("Enter a miles driven: ");
                Mile = Convert.ToInt32(Console.ReadLine());
                if (Mile < 0) { break; }
                MileSum = MileSum + Mile;
                Console.Write("Enter a gallons used: ");
                Gallon = Convert.ToInt32(Console.ReadLine());
                if (Gallon < 0) { Gallon = -1 * Gallon; }
                GallonSum = GallonSum + Gallon;
                MPG = (float)(Mile) / (float)(Gallon);
                Console.WriteLine("MPG = " + MPG.ToString("N2"));
                SumMPG = (float)MileSum / (float)GallonSum;
                Console.WriteLine("Total MPG = " + SumMPG.ToString("N2"));
            }

        }
    }
}
