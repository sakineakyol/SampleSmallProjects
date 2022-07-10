using System;

namespace MakingBeverageChoice
{
    class Program
    {
        //A program that prints which beverage someone prefers according to the preference information received from the user. (Tea: T - Lemonade: L - Soda: S - Cola: C)
        static void Main(string[] args)
        {
        preferAgain: Console.WriteLine("Which drink do you prefer? \n Tea: T - Lemonade: L - Soda: S - Cola: C ");

            string prefer = Console.ReadLine();
            #region IF- ELSE

            if (prefer == "T" || prefer == "t")
            {
                Console.WriteLine("Your beverage of choice was tea.");
            }
            else if (prefer == "L" || prefer == "l")
            {
                Console.WriteLine("Your beverage of choice was lemonade.");
            }
            else if (prefer == "S" || prefer == "s")
            {
                Console.WriteLine("Your beverage of choice was soda.");
            }
            else if (prefer == "C" || prefer == "c")
            {
                Console.WriteLine("Your beverage of choice was cola.");
            }
            else
            {
                Console.WriteLine("You chose the wrong drink. Please try again.");
                goto preferAgain;
            }
            #endregion

            #region SWITCH - CASE
            //No comparisons are made in the switch case. Only variable is written. In each of the cases, the values to be controlled are written in that variable.
            switch (prefer)
            {
                case "T":
                case "t":
                    Console.WriteLine("Your beverage of choice was tea.");
                    break;
                case "L":
                case "l":
                    Console.WriteLine("Your beverage of choice was lemonade.");
                    break;
                case "S":
                case "s":
                    Console.WriteLine("Your beverage of choice was soda.");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Your beverage of choice was cola.");
                    break;
                default:
                    Console.WriteLine("You chose the wrong drink. Please try again.");
                    goto preferAgain;

            }
            #endregion
        }
    }
}
