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

            //int number = 12345;
            //string numberString = number.ToString();
            //Console.WriteLine(numberString);
            //Console.WriteLine(numberString.Length);
            ////Console.WriteLine(number/numberString.Length);
            //Console.WriteLine(number/10000);


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
                            Console.Write(fillChar+ " ");
                        }
                    }
                    Innercounter++;
                }
                Outercounter++;
                Innercounter = 0;
                Console.WriteLine();
            }
        }
    }
}
