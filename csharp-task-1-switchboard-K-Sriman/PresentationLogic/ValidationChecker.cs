using System;
using System.Text.RegularExpressions;

namespace PresentationLogic
{
    public static class ValidationChecker
    {//getinput 
        public static int GetValidatedInput(string InputData, string pattern = "^[1-9]*$")
        {
            while (true)
            {
                //inputdata chnage it 
                Console.WriteLine(InputData);
                string input = Console.ReadLine();
                if (!Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                else
                {
                    return Convert.ToInt32(input);
                }
            }
        }
    }
}
