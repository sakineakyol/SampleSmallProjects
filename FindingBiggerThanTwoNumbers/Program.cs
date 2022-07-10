using System;

namespace FindingBiggerThanTwoNumbers
{
    class Program
    {
        //A program that finds the larger of two numbers entered before or after the two numbers received from the user, and prints it on the screen.

        /*
             * 1. Step:  Start
             * 2. Step: Get number1 and number2 value from user
             * 3. Step: If number1 > number2 write to screen ("Number1 bigger than number2")
             * 4. Step: If number2 > number1 write to screen ("Number2 bigger than number1")
             * 5. Step: If number2 = number1 write to screen ("The 2 numbers entered are equal to each other.")       
             * 6. Step: End
            
             */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine("The first number entered is bigger than the second number.");

            if (number2 > number1)
                Console.WriteLine("The second number entered is bigger than the first number.");

            if (number1 == number2)
                Console.WriteLine("The 2 numbers entered are equal to each other. First entered number ({0}), second entered number ({1})", number1, number2);

            Console.ReadLine();
        }
    }
}
