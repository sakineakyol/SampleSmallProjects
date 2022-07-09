using System;

namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //The algorithm prints the phase of the water according to the temperature information of the water received from the user.
            /*
             * 1. Step:  Start
             * 2. Step: Get water temperature information from user (waterTemp)
             * 3. Step: If waterTemp is >=100, write on screen ("Water is in Gaseous State")
             *          Otherwise, if waterTemp <=0, write to screen ("Water is in Solid")
             *          Otherwise, write to screen ("Water is in Liquid")
             * 4. Step: End
             */
            Console.WriteLine("Please enter the water temperature value in Celsius: ");
            double waterTemp = Convert.ToDouble(Console.ReadLine());

            if (waterTemp > 100)
            {
                Console.WriteLine("Water is in a Gaseous State");
            }
            else if (waterTemp == 100)
            {
                Console.WriteLine("Water is in a Gaseous or Liquid State");
            }
            else if (waterTemp < 0)
            {
                Console.WriteLine("Water is in a Solid State");
            }
            else if (waterTemp == 0)
            {
                Console.WriteLine("Water is in a Solid or Liquid State");
            }
            else
            {
                Console.WriteLine("Water is in a Liquid State");
            }
        }
    }
}
