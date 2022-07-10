using System;

namespace FactorialCalculation
{
    class Program
    {
        //The algorithm calculates the factorial of a number received from the user and prints it on the screen.
        /*
             * 1. Step:  Start
             * 2. Step: Get number value from user
             * 3. Step: factorial =1, counter= 1
             * 4. Step: If number == 0, factorial = 1. Go to step 7.
             * 5. Step: If counter < number , counter = counter + 1
             *          Otherwise, Go to step 7.
             * 6. Step: factorial = factorial * counter. Go to step 5.
             * 7. Step:  Write to the screen ("Number Entered: ", number , "Factorial of Number: ", factorial)
             * 8. Step: End
             */

        //Redirection is for 'if' only. Not for 'Else' or 'Else if'.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number value for which you want to calculate the factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1, counter = 1;

        control: if (number == 0)
            {
                factorial = 1;
                goto writeScreen;
            }
            else if (number < 0)
            {
                goto negativeNumber;
            }
            else if (number > counter)
            {
                //counter = counter +1;
                counter++;
                //step 6
                factorial = factorial * counter;
                goto control;
            }
            else
            {
                goto writeScreen; 
            }

            

          writeScreen: Console.WriteLine("Number Entered: " + number + " Factorial of Number: " + factorial); //  step 7
            goto end;
            negativeNumber: Console.WriteLine("A negative number was entered. The factorial calculation of negative numbers is not done.");


            end: Console.ReadLine();
        }
    }
}
