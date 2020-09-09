﻿using System;
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
            int number = 0;
            Console.Write("Enter 9 digit number : ");
            number = Convert.ToInt32(Console.ReadLine());

            while ((number / Math.Pow(10, 9)) > 0)
            {
                Console.WriteLine("Entered number is not a 9 digit number, try again.");
                Console.Write("Enter 9 digit number : ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            // then check the palindrome only once.
            //string NumberString = number.ToString();
            //int sub1 = Convert.ToInt32(NumberString.Substring(0,5));
            //int sub2 = Convert.ToInt32(NumberString.Substring(4));
            
            
        }
    }
}
