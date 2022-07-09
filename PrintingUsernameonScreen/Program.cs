using System;

namespace PrintingUsernameonScreen
{
    class Program
    {
        //Example:  Write the algorithm and program that prints the e-mail address as "name.surname@mail.com" according to the name and surname received from the user.
        static void Main(string[] args)
        {
            /*Algorithm:
             * 1.Step: Start
             * 2.Step: Get name value from user
             * 3.Step: Get surname value from user
             * 4.Step: mailAddress = name.surname@mail.com
             * 5.Step: Print Screen(mailAddress)
             * 6.Step: End
             */
            string name, surname, mailAddress;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your surname");
            surname = Console.ReadLine();

            mailAddress = name + "." + surname + "@mail.com";

            Console.WriteLine("Your generated e-mail address: "+ mailAddress);
            //Console.WriteLine("Your generated e-mail address: " + (name + "." + surname + "@mail.com"));
            Console.ReadLine();


        }
    }
}
