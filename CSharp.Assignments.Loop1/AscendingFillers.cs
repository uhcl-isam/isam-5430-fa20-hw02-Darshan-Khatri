using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {
            // Complete your loop codes here.
            int LastMaxNumber = -2;
            int inputNumber = 0;

            int cumulativeSumOfIncresedNumber = 0;

            Console.Write("Enter a number: ");
            string inputString = Console.ReadLine();
            inputNumber = Convert.ToInt32(inputString);

            if (inputNumber >= 0 || inputString != null)
            {
                do
                {
                    if (inputNumber > LastMaxNumber)
                    {
                        LastMaxNumber = inputNumber;
                    }
                    else if (inputNumber == LastMaxNumber)
                    {
                        inputNumber++;
                        LastMaxNumber = inputNumber;
                        cumulativeSumOfIncresedNumber++;
                    }
                    else if (inputNumber < LastMaxNumber)
                    {
                        int Diff = LastMaxNumber - inputNumber;
                        LastMaxNumber = inputNumber + Diff + 1;

                        cumulativeSumOfIncresedNumber += Diff + 1;
                    }

                    //Console.WriteLine($"{LastMaxNumber} ");
                    //Console.WriteLine("Current sum: " + cumulativeSumOfIncresedNumber);
                    Console.Write("Enter a number: ");
                    inputString = Console.ReadLine();
                    inputNumber = Convert.ToInt32(inputString);
                    if (inputNumber == 0)
                    {
                        LastMaxNumber = -1;
                    }
                } while (inputNumber >= 0 && inputString != null);
                Console.WriteLine($"Sum of added number is = {cumulativeSumOfIncresedNumber}");
            }
        }
    }
}
