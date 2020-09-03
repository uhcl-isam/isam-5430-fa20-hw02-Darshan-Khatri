using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app that requires two inputs:
    /// the number of rows/columns and the fill character (char).
    /// The app will then provide output statements to display the
    /// checkerboard pattern that follows. A Console.WriteLine method
    /// call with no arguments outputs a single newline character. 
    /// [Hint: Iteration statements are required.]
    /// <example>
    /// For 8 rows and a fill character of '*', the app will produce
    ///  an 8 by 8 checkerboard as follows:
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// * * * * * * * *
    ///  * * * * * * * *
    /// </example>
    /// </summary>
    public class CheckerboardPattern
    {
        public static void Main()
        {
            Console.Write("Enter the number of rows: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fill character: ");
            char fillChar = Char.Parse(Console.ReadLine());

            int Outercounter = 0;
            int Innercounter = 0;

            while (Outercounter < num)
            {
                while (Innercounter < num)
                {
                    if (Outercounter == 0 || Outercounter % 2 == 0)
                    {
                        Console.Write(fillChar + " ");
                    }
                    else
                    {
                        if (Innercounter == 0)
                        {
                            Console.Write(" " + fillChar + " ");
                        }
                        else
                        {
                            Console.Write(fillChar + " ");
                        }
                    }
                    Innercounter++;
                }
                Outercounter++;
                Innercounter = 0;
                Console.WriteLine();
            }

            // Write your codes here.
        }
    }
}
