using CSharp.Assignments.Loop1;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace CSharp.Assignments.Selection1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 23;
            //int num2 = 61;
            ////Console.WriteLine(num1 % 20);
            ////Console.WriteLine(num2 % 20);
            //Console.WriteLine(((num2 - 2) % 20));


            //static int myfunc(int tea, int candy)
            //{
            //    if ((tea >= 5 && candy >= 5) && ((tea >= (2 * candy)) || (candy >= (2 * tea))))
            //    {
            //        return 2;
            //    }
            //    if (tea >= 5 && candy >= 5)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //    throw new NotImplementedException();
            //}

            //num1 = myfunc(11, 6);
            //Console.WriteLine("My function = " + num1);

            //int number = 12345;
            //string numberString = number.ToString();
            //Console.WriteLine(numberString);
            //Console.WriteLine(numberString.Length);
            ////Console.WriteLine(number/numberString.Length);
            //Console.WriteLine(number/10000);


            //Console.Write("Enter the number of rows: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the fill character: ");
            //char fillChar = Char.Parse(Console.ReadLine());

            //int Outercounter = 0;
            //int Innercounter = 0;

            //while (Outercounter < num)
            //{
            //    while (Innercounter < num)
            //    {
            //        if (Outercounter == 0 || Outercounter % 2 == 0)
            //        {
            //            Console.Write(fillChar + " ");
            //        }
            //        else
            //        {
            //            if (Innercounter == 0)
            //            {
            //                Console.Write(" " + fillChar + " ");
            //            }
            //            else
            //            {
            //                Console.Write(fillChar+ " ");
            //            }
            //        }
            //        Innercounter++;
            //    }
            //    Outercounter++;
            //    Innercounter = 0;
            //    Console.WriteLine();
            //}


            //int accountNumber = 0;
            //Console.Write("Enter your account number: ");
            //accountNumber = Convert.ToInt32(Console.ReadLine());
            //while (accountNumber > 0)
            //{
            //    int balance = 0;
            //    Console.Write("Enter your balance: ");
            //    balance = Convert.ToInt32(Console.ReadLine());

            //    int chargeAmount = 0;
            //    Console.Write("Enter total charge you for this month: ");
            //    chargeAmount = Convert.ToInt32(Console.ReadLine());

            //    int credit = 0;
            //    Console.Write("Enter credit for this month: ");
            //    credit = Convert.ToInt32(Console.ReadLine());

            //    int AllowedCredit = 0;
            //    Console.Write("Enter allowed credit limit: ");
            //    AllowedCredit = Convert.ToInt32(Console.ReadLine());

            //    int CalcNewBalance = 0;
            //    CalcNewBalance = balance + chargeAmount - credit;
            //    Console.WriteLine($"New Balance = {CalcNewBalance}");
            //    if (CalcNewBalance > AllowedCredit)
            //    {
            //        Console.WriteLine("Credit limit exceeded!");
            //    }

            //    Console.Write("Enter your account number: ");
            //    accountNumber = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Error.WriteLine("Enter the number of lines.");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int outerCounter = 0;
            //int innerCounter = 0;

            //while (outerCounter < n)
            //{
            //    while (innerCounter <= outerCounter)
            //    {
            //        Console.Write("*");
            //        innerCounter++;
            //    }
            //    Console.WriteLine();
            //    outerCounter++;
            //    innerCounter = 0;
            //}
            //Console.WriteLine("------------------------");
            //outerCounter = n;
            //innerCounter = 0;
            //while (outerCounter > 0)
            //{
            //    while (innerCounter < outerCounter)
            //    {
            //        Console.Write("*");
            //        innerCounter++;
            //    }
            //    Console.WriteLine();
            //    outerCounter--;
            //    innerCounter = 0;
            //}

            //Console.WriteLine("------------------------------------------");
            //outerCounter = n;
            //innerCounter = 0;
            //while (outerCounter > 0)
            //{
            //    while (innerCounter < n)
            //    {
            //        if (innerCounter < n- outerCounter)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        innerCounter++;
            //    }
            //    Console.WriteLine();
            //    outerCounter--;
            //    innerCounter = 0;
            //}


            //Console.WriteLine("*--------------------------------------");
            //outerCounter = n;
            //innerCounter = 1;

            //outerCounter = n;
            //innerCounter = 1;
            //while (outerCounter > 0)
            //{
            //    while (innerCounter <= n)
            //    {
            //        if (innerCounter < outerCounter)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        innerCounter++;
            //    }
            //    Console.WriteLine();
            //    outerCounter--;
            //    innerCounter = 1;
            //}

            //***************************************************************************************
            //Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
            //int end = int.Parse(Console.ReadLine());
            //int num1 = 0;
            //int num2 = 1;
            //int cumalativeSum = 0;

            //cumalativeSum = num1 + num2;
            ////0 1 1 2 3 5 8 13 21 34 55 89...
            //while (cumalativeSum < end)
            //{
            //    num1 = num2;
            //    num2 = cumalativeSum;
            //    cumalativeSum = num1 + num2;
            //    if (cumalativeSum > end)
            //    {
            //        cumalativeSum = num2;
            //        break;
            //    }
            //}

            //Console.WriteLine(cumalativeSum);
            //*************************************************


            //int totalMiles = 0;
            //int totalGallons = 0;
            //int miles = 0;
            //// prompt user for non-negative miles and obtain the input from user
            //while (miles >= 0)
            //{
            //    Console.Write("How many miles you have driven till now: ");
            //    miles = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.Write("Enter amount of gallons used to drive miles, you have mentioned above: ");
            //    int Gallons = Convert.ToInt32(Console.ReadLine());
            //    // codes go here.
            //    decimal Average = (miles / Gallons);
            //    Console.WriteLine($"Miles per gallon = {Average}");

            //    totalMiles += miles;
            //    totalGallons += Gallons;
            //    decimal totalAverage = totalMiles / totalGallons;
            //    Console.WriteLine($"Total miles per gallons = {totalAverage}");
            //}

            //int floating = ((123456789) / (int)Math.Pow(10, 8));
            //Console.WriteLine(floating);
            //int floating1 = ((123454321) / (int)Math.Pow(10, 5));
            //Console.WriteLine(floating1);
            //int floating2 = ((123454321) % 10);
            //Console.WriteLine(floating2);

            //string Mystr = "";
            //int number = 123454321;
            //Mystr = number.ToString();
            //Console.WriteLine($"Original String = {Mystr}");
            //string sub1 = Mystr.Substring(0, 5);
            //Console.WriteLine($"Sub1 String = {sub1}");

            //string sub2 = Mystr.Substring(4);
            //Console.WriteLine($"Sub2 String = {sub2}");
            //Console.WriteLine(Convert.ToInt32(sub2));

            //***********************LArgest**************

            //int counter = 1;
            //int number = 0;
            //int largest = 0;
            //int largest2 = 0;
            //// get first number and assign it to variable largest
            //while (counter < 11)
            //{
            //    //3 10 2 5 8

            //    Console.Write("Enter a number: ");
            //    number = Convert.ToInt32(Console.ReadLine()); //8
            //    if (counter == 1)
            //    {
            //        largest = number; //largest = 3
            //    }
            //    else
            //    {
            //        if (number < largest && number > largest2)
            //        {
            //            largest2 = number; //largest2 = 8
            //        }
            //        else if (number > largest)
            //        {
            //            largest2 = largest; // 
            //            largest = number; // largest = 10
            //        }
            //    }
            //    counter++;
            //}
            //Console.WriteLine($"Largest = {largest}");
            //Console.WriteLine($"Largest2 = {largest2}");
            //************************************************************

            //***********OddNumber*************************************

            int startNum = 0;
            Console.Error.WriteLine("Enter the starting number");
            startNum = Convert.ToInt32(Console.ReadLine());
            // Codes to enter start
            int endNum = 0;
            Console.Error.WriteLine("Enter the ending number");
            endNum = Convert.ToInt32(Console.ReadLine());
            // Codes to enter end.
            //int number = 0;
            while (startNum <= endNum)
            {
                if (startNum % 2 != 0)
                {
                    Console.WriteLine(startNum);
                    startNum += 2;
                }
                else
                {
                    startNum++;
                    //Console.WriteLine(startNum);
                }
            }
        }
    }
}
