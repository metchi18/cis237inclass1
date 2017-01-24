using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCsv(string pathToCSVFile, Employee[] employees)
        {
            //Declare the StreamReader
            StreamReader streamReader = null;

            try
            {
                //declare a strign for the line
                string line;

                //Instantiate the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                //While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null) ;
                {
                    //Process the line
                    processLine(line, employees, counter++);
                }

                //Read through the whole file, so we can return true.
                return true;
            } catch (Exception e)
            {
                //Output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //return false because it didn't work
                return false;
            }
            finally
            {
                //Check to see if Streamreader was instantiated, make sure it is closed before exiting the reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }     
        }

        private void processLine(string line, Employee[] employee, int index)
        {
            //declare array of parts that will contain the results of splitting the read in string
            string[] parts = line.Split(',');

            //Assign each part to a variable- dont have to do this
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //Add an employee into the array that was passed in.
            employee[index] = new Employee(firstName, lastName, salary);

        }
    }
}
