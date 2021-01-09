using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01
{
    class Program
    {
        /**
         * Simple demostration program of our first assigment on W01
         */
        static public void Main(string[] args)
        {
            //My Info
            string name = "Filipe Ferreira";
            string location = "Minas Gerais, Brazil";

            //Display my info on the console
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My Location is {location}");

            //Output the current date but not the current time
            DateTime localDate = DateTime.UtcNow;
            Console.WriteLine($"My local date it {localDate.ToShortDateString()}");

            //Output the number of days until Christmas this year
            DateTime christmas = new DateTime(2021, 12, 25);
            var timeToChristmas = christmas.Subtract(localDate).TotalDays;
            Console.WriteLine($"Total days to Christmas: {Convert.ToInt32(timeToChristmas)}");

            //Edited code Rob Miles Example
            robMilesExample();

            //Just to exit the program
            Console.WriteLine("\nPress any Key to end the app");
            Console.ReadKey();
        }

        /**
         * 2.1 in the C# Programming Yellow Book by Rob Miles
         */
        static private void robMilesExample()
        {
            //Declare the variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Prompt the user
            Console.Write("\nRob Miles Wood and Glass Window Caculation Example:\n\nPlease enter the width: ");
            widthString = Console.ReadLine();

            //Convert width to double
            width = double.Parse(widthString);

            //Prompt the user
            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();

            //Convert height to double
            height = double.Parse(heightString);

            //Peform the caculation
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Display th values
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");

        }
    }
}
