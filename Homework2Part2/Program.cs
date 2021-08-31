/*using System;

namespace Homework2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/


/// Homework Week No. 2		Exercise No. 1
/// Solution Name: Homework2Part1
/// @author: Balaji Venkataraman
/// Date:  August 30, 2021
///
/// Problem Statement: Convert Fahrenheit to Celsius 
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for a temperature in deg F as a whole number 
/// 3) Calculate the temperature equivalent in deg C 
/// 4) Print the output message to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Part2
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // declare an integer variable for deg F (userinput)
            int ndegF;
            double ndegC;
            string userInput;

            // print a message to the screen & receive input
            Console.WriteLine("Week 2; Homework 2");
            Console.WriteLine("Hello there. This HW shows arithematic expressions, by");
            Console.WriteLine("converting a given temperature in deg F to deg C.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter the temperature in degree F as a whole number & press [Enter]: ");
            
            userInput = Console.ReadLine();
            ndegF = Int32.Parse(userInput);

            // calcualte the deg C equivalent
            ndegC = 5 * ((double) ndegF - 32) / 9;

            // print the output message & output the deg C to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Output");
            Console.WriteLine("======");
            Console.WriteLine("Your  input temperature in deg F is: " + ndegF );
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your output temperature in deg C is: " + Math.Round(ndegC,1));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}