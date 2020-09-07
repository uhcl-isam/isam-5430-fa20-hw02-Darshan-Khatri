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
            //**************Using ConsoleKeyInfo****************************
            //int inputNum = 0;
            //string StringNumber = "";
            //int lastNum = -1;
            //int groupCounter = 0;
            //int clumps = 0;
            //int i = 0;

            //Console.Write("Enter a number: ");
            //ConsoleKeyInfo cki;
            //cki = Console.ReadKey(); Console.WriteLine();
            //do
            //{
            //    StringNumber = cki.KeyChar.ToString();
            //    inputNum = Convert.ToInt32(StringNumber);
            //    if (inputNum == lastNum && i > 0)
            //    {
            //        groupCounter++;
            //    }
            //    else
            //    {
            //        if (groupCounter >= 1)
            //        {
            //            clumps++;
            //            groupCounter = 0;
            //        }
            //        lastNum = inputNum;
            //    }

            //    Console.Write("Enter a number: ");
            //    cki = Console.ReadKey(); Console.WriteLine();

            //    if (cki.Key == ConsoleKey.Z || cki.Modifiers == ConsoleModifiers.Control)
            //    {
            //        if (groupCounter >= 1)
            //        {
            //            clumps++;
            //        }
            //    }
            //    i++;

            //} while (cki.Key != ConsoleKey.Z || cki.Modifiers != ConsoleModifiers.Control);
            //Console.WriteLine($"Number of clumps are is equal to: {clumps}");

            int inputNum = 0;
            string StringNumber = "";
            int lastNum = -1;
            int groupCounter = 0;
            int clumps = 0;
            int i = 0;

            Console.Write("Enter a number: ");
            StringNumber = Console.ReadLine();

            do
            {
                inputNum = Convert.ToInt32(StringNumber);
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

                StringNumber = Console.ReadLine();

                if (StringNumber == null)
                {
                    if (groupCounter >= 1)
                    {
                        clumps++;
                    }
                }

                i++;
            } while (StringNumber != null);
            Console.WriteLine($"Number of clumps are is equal to: {clumps}");

        }
    }
}
