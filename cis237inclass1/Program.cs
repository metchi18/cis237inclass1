using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of he User Interface Class
            UserInterface ui = new UserInterface();

            //Here is a new employee being created using the default constructors
            //we wrote in he Employee class
            //Even though we aren't using it, it shows a single instance of one vs
            //an array of them.
            Employee myEmployee = new Employee();

            //Let's make an array to hold a bunch of instances of Employee class
            Employee[] employees = new Employee[10];

            //Let's add some employees to our array
            //employees[0] = new Employee(" David", "Barnes", 835.00m);
            //employees[1] = new Employee("James", "Kirk", 453.00m);
            //employees[2] = new Employee("Jean-Luc", "Picard", 290.00m);
            //employees[3] = new Employee("Benjamin", "Sisco", 587.00m);
            //employees[4] = new Employee("Kathryn", "Janeway", 194.00m);
            //employees[5] = new Employee("Johnathan", "Archer", 135.00m);

            //Make string for the path to the csv file
            string pathToCsv = "../employees.csv";

            //Instantiate the csvProcessor
            CSVProcessor csvProcessor = new CSVProcessor();

           //Call the ImportCSV method sending over the path and the array to store the read in records to.
            csvProcessor.ImportCsv(pathToCsv, employees);

            //Get input fromt he user
            int choice = ui.GetUserInput();

            //While the choice is not 2, continue to do work
            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    string outputString = "";

                    //Print out the emloyees in the array
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            //Concat to the outputString
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }

                    }

                    //use the UI class to print out the string
                    ui.Output(outputString);

                }

                //re-prompt the user for input
                choice = ui.GetUserInput();
            }


           

        }

    }
}
