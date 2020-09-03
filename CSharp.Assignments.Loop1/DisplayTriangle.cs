using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Write an app reads two inputs: a character that indicates which pattern to choose ('a' = lower left triangle, 'b' = upper left triangle, 'c' = upper right triangle, 'd' = lower right triangle) and an integer that indicates the number of lines to display. The app will then display the following patterns separately, one below the other. Use for loops to generate patterns. All asterisks (*) should be displayed by a signle statement of the form Console.Write('*'); which causes the asterisks to display side by side. A statement of the form Console.WriteLine(); can be used to move to the next line. A statement of the form COnsole.Write(' '); can be used to display a space for the last two patterns., There should be no other output statements in the app. [Hint: the last two patterns require that each line begin with an appropriate number of blank spaces.
    /// </summary>
    /// <example>
    ///    (a)          (b)         (c)          (d)
    /// *           **********  **********           *
    /// **          *********    *********          **
    /// ***         ********      ********         ***
    /// ****        *******        *******        ****
    /// *****       ******          ******       *****
    /// ******      *****            *****      ******
    /// *******     ****              ****     *******
    /// ********    ***                ***    ********
    /// *********   **                  **   *********
    /// **********  *                    *  **********
    /// </example>
    public class DisplayTriangle
    {
        public static void Main()
        {
            Console.Error.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; 'c' = upper right triangle; 'd' = lower right triangle.");
            char t = Convert.ToChar(Console.ReadLine());
            Console.Error.WriteLine("Enter the number of lines.");
            int n = Convert.ToInt32(Console.ReadLine());

            int outerCounter = 0;
            int innerCounter = 0;

            if (t == 'a')
            {
                while (outerCounter < n)
                {
                    while (innerCounter <= outerCounter)
                    {
                        Console.Write("*");
                        innerCounter++;
                    }
                    Console.WriteLine();
                    outerCounter++;
                    innerCounter = 0;
                }

                outerCounter = 0;
                innerCounter = 0;
            }

            else if (t == 'b')
            {
                outerCounter = n;

                while (outerCounter > 0)
                {
                    while (innerCounter < outerCounter)
                    {
                        Console.Write("*");
                        innerCounter++;
                    }
                    Console.WriteLine();
                    outerCounter--;
                    innerCounter = 0;
                }

                outerCounter = 0;
                innerCounter = 0;
            }

            else if (t == 'c')
            {
                outerCounter = n;
                innerCounter = 1;
                while (outerCounter > 0)
                {
                    while (innerCounter <= n)
                    {
                        if (innerCounter <= n- outerCounter)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        innerCounter++;
                    }
                    Console.WriteLine();
                    outerCounter--;
                    innerCounter = 1;
                }

                outerCounter = 0;
                innerCounter = 0;
            }

            else if (t == 'd')
            {
                outerCounter = n;
                innerCounter = 1;
                while (outerCounter > 0)
                {
                    while (innerCounter <= n)
                    {
                        if (innerCounter < outerCounter)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        innerCounter++;
                    }
                    Console.WriteLine();
                    outerCounter--;
                    innerCounter = 1;
                }

                outerCounter = 0;
                innerCounter = 0;
            }

            Console.ReadLine();
        }
    }
}
