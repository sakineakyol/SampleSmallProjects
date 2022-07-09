using System;

namespace CalculatingTheSquare
{
    class Program
    {
        //Write the algorithm and program that calculates the square of an integer received from the user and prints it to the screen.
        //Kullanıcıdan alınan bir tam sayının karesini hesaplayıp ekrana yazdıran algoritmayı ve programı yazınız.

        /*
         * 1. Step: Start
         * 2. Step: Prompt the user for a number value.
         * 3. Step: Square = number * number
         * 4. Step: Write Screen
         * 5. Step: End
         * */
        static void Main(string[] args)
        {
            int number, square;

            Console.WriteLine("Please enter an integer you want to square:");

            number = Convert.ToInt32(Console.ReadLine());

            square = number * number;
            Console.WriteLine("Square of the entered number: "+ square);
            Console.ReadLine();
        }
    }
}
