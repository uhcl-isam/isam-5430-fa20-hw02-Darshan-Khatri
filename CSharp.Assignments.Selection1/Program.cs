using CSharp.Assignments.Loop1;
using System;

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

            int number = 12345;
            string numberString = number.ToString();
            Console.WriteLine(numberString);
            Console.WriteLine(numberString.Length);
            //Console.WriteLine(number/numberString.Length);
            Console.WriteLine(number/10000);
        }
    }
}
