using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            int inputNum = 0;
            Console.Write("Enter a number: ");

            inputNum = Convert.ToInt32(Console.ReadLine());
            int lastNum = 0;
            lastNum = inputNum;

            int groupCounter = 0;

            int clumps = 0;

            int i = 0;

            while (inputNum >= 0)
            {
                if (inputNum == lastNum && i > 0)
                {
                    groupCounter++;
                }
                else
                {
                    if (groupCounter >= 1)
                    {
                        clumps++;
                        groupCounter = 0;
                    }
                    lastNum = inputNum;
                }

                Console.Write("Enter a number: ");
                inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum < 0)
                {
                    clumps++;
                }
                i++;
            }
            Console.WriteLine($"Number of clumps are is equal to: {clumps}");

        }
    }
}
