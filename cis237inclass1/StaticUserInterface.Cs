using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    static class StaticUserInterface
    {
        //No variables
        //No properties
        //No constructors (but we could if we needed to)

        //*****************
        //Methods
        //*****************

        public static int GetUserInput()
        {
            //Print out a menu
            PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid, re-get the input
            while (input != "1" && input != "2")
            {
                //Print error message
                PrintErrorMessage();

                //Re-Print the menu
                PrintMenu();

                //Get the input from the console again
                input = Console.ReadLine();
            }

            //At this point, I know the input is a valid number of either a 1 or a 2
            return Int32.Parse(input);
            //If the input is good, return it.

        }

        public static void Output(String outputString)
        {
            Console.WriteLine(outputString);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private static void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
        }
    }
}
