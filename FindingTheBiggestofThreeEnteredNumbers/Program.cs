using System;

namespace FindingTheBiggestofThreeEnteredNumbers
{
    class Program
    {
        //A program that finds the biggest of three numbers entered before or after the three numbers received from the user, and prints it on the screen.

        /*
           * 1. Step:  Start
           * 2. Step: Get number1,number2 and number3 value from user
           * 3. Step: If number1 > number2 and number1 > number3 then Write to Screen("Number1 is the biggest number.)
            *           Otherwise, If number2 > number1 and number2 > number3, Write to Display("Number2 is the biggest number.)
            *           Otherwise, If number3 > number1 and number3 > number2, Write to Display("Number is the biggest number.)
            *           Otherwise, Write to Screen("Numbers Equal")
           * 4. Step: End
           */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            double number2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter the third number.");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double biggest = number1;

            if (number2 > biggest)
            {
                biggest = number2;
                if (number3 > biggest)
                {
                    biggest = number3;
                }
            }
            else
            {
                if (number3 > biggest)
                {
                    biggest = number3;
                }
            }

            Console.WriteLine("The biggest of the numbers you entered: " + biggest);
            Console.ReadLine();

        }
    }
}
