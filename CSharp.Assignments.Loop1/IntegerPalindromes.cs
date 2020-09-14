using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            long OriginalNumber = 0;
            //Console.Write("Enter 9 digit number : ");
            OriginalNumber = Convert.ToInt64(Console.ReadLine());

            while ((((OriginalNumber / Math.Pow(10, 9)) > 0.99999F) || ((OriginalNumber / Math.Pow(10, 9)) <= 0.1F)))
            {
                Console.WriteLine("Entered number is not a 9 digit number, try again.-> ");
                OriginalNumber = Convert.ToInt64(Console.ReadLine());
            }



            // then check the palindrome only once.
            //string NumberString = number.ToString();
            //int sub1 = Convert.ToInt32(NumberString.Substring(0,5));
            //int sub2 = Convert.ToInt32(NumberString.Substring(4));
            int number1 = 0, number2 = 0, number3 = 0, number4 = 0, counter = 0, mod;
            double division = OriginalNumber;

            bool redFlag = true;

            while (counter < 10)
            {
                mod = (int)division % 10; //1
                division = division / 10; //12345432.1
                division = Math.Truncate(division); //12345432

                if (counter == 0)
                {
                    number1 = mod; // number1 = 1
                }
                else if (counter == 1)
                {
                    number2 = mod; // number2 = 2
                }
                else if (counter == 2)
                {
                    number3 = mod; // number3 = 3
                }
                else if (counter == 3)
                {
                    number4 = mod; // number4 = 4
                }
                else if (counter == 5 && mod != number4)
                {
                    redFlag = false;
                    break;
                }
                else if (counter == 6 && mod != number3)
                {
                    redFlag = false;
                    break;
                }
                else if (counter == 7 && mod != number2)
                {
                    redFlag = false;
                    break;
                }
                else if (counter == 8 && mod != number1)
                {
                    redFlag = false;
                    break;
                }

                counter++;

            }

            if (redFlag)
            {
                Console.WriteLine($"Palindrome");
            }
            else
            {
                Console.WriteLine($"Not Palindrome");
            }


        }
    }
}
