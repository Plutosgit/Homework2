

/// Homework Week No. 2		Exercise No. 1
/// Solution Name: Homework2Part1
/// @author: Balaji Venkataraman
/// Date:  August 30, 2021
///
/// Problem Statement: Output the pig latin name to the screen, given a first and last name.
/// 
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for 2 strings (first and last name)
/// 3) Create the PigLatin name 
/// 4) Print the PigLatin to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Part1
{
    class MyFirstProgram
    {
        static void Main(string[] args)
        {
            // declare two string variables for first & last names and a string variable for the final output in Piglatin
            string sFirstname, sLastname;
            string sPLname = "", sPL1 = "", sPL2 = "";
            string userInput;

            // print a message to the screen & receive the 2 string inputs
            Console.WriteLine("Week 2; Homework 1");
            Console.WriteLine("Hello out there. This HW shows string manipulation, by");
            Console.WriteLine("creating PigLatin names from given first & last names.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter the first name in lowercase & press [Enter]: ");
            userInput = Console.ReadLine();
            sFirstname = userInput.ToLower();

            Console.Write("Enter the  last name in lowercase & press [Enter]: ");
            userInput = Console.ReadLine();
            sLastname = userInput.ToLower();

            // create the PigLatin name
            // process firstname
            switch (sFirstname.Length)
            {

                case 0:
                    Console.WriteLine("The first name must not be empty. Cannot form PigLatin name.");
                    break;
                case 1:
                    sPL1 = sFirstname.ToUpper() + "ay";
                    break;
                case 2:
                    sPL1 = sFirstname.Substring(1, 1).ToUpper() + sFirstname.Substring(0, 1) + "ay";
                    break;
                default:
                    sPL1 = sFirstname.Substring(1, 1).ToUpper() + sFirstname.Substring(2, sFirstname.Length - 2) + sFirstname.Substring(0, 1) + "ay";
                    break;
            }

            // process lastname
            switch (sLastname.Length)
            {

                case 0:
                    Console.WriteLine("The last  name must not be empty. Cannot form PigLatin name.");
                    break;
                case 1:
                    sPL2 = sLastname.ToUpper() + "ay";
                    break;
                case 2:
                    sPL2 = sLastname.Substring(1, 1).ToUpper() + sLastname.Substring(0, 1) + "ay";
                    break;
                default:
                    sPL2 = sLastname.Substring(1, 1).ToUpper() + sLastname.Substring(2, sLastname.Length - 2) + sLastname.Substring(0, 1) + "ay";
                    break;
            }

            // now combine to form the Piglatin name
            sPLname = sPL1 + " " + sPL2;

            // print the output message with the Piglatin name to the screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Output");
            Console.WriteLine("======");
            Console.WriteLine("Your first and last names are: " + sFirstname + ", " + sLastname);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The PigLatin equivalent is   : " + sPLname);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}