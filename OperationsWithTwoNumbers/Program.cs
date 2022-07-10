using System;

namespace OperationsWithTwoNumbers
{
    class Program
    {
        //A program that finds the sums of two numbers if any of the 2 integers received from the user is negative, their product if both are negative, and the arithmetic averages if both are positive. If 0 is entered, whatever number 0 was entered should be requested again.
        static void Main(string[] args)
        {

        numberAgain: Console.WriteLine("Please enter the first number.");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 == 0)
            {
                Console.WriteLine("You cannot enter the number 0 in this application. Please re-enter the 1st number:");
                goto numberAgain;
            }

        numberAgain2: Console.WriteLine("Please enter the second number.");
            int number2 = int.Parse(Console.ReadLine());

            if (number2 == 0)
            {
                Console.WriteLine("You cannot enter the number 0 in this application. Please re-enter the 2nd number:");
                goto numberAgain2;
            }



            if (number1 < 0 || number2 < 0)
            {
                Console.WriteLine("Since one of the numbers is entered as negative, their total is:" + (number1 + number2));
            }
            else if (number1 < 0 && number2 < 0)
            {
                Console.WriteLine("Since both numbers are negative, the product of two numbers is:" + (number1 * number2));
            }
            else if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("Since two positives are entered, the arithmetic mean of the numbers is::" + ((number1 + number2) / 2));
            }


            Console.ReadLine();
        }
    }
}
