using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            bool validInput = false;
            string response = "";
            while (!validInput)
            {
                Console.WriteLine("Please enter your " + prompt + ".");
                response = Console.ReadLine();
            }
            return response;
        }
        public static bool ValidateEmail(string userInput)
        {
            string[] splitOnAt = userInput.Split('@');
            if (splitOnAt.Length != 2 || splitOnAt[0].Length == 0 || splitOnAt[1].Length == 0)
            {
                return false;
            }
            string[] splitSecondHalfOnDot = splitOnAt[1].Split('.');
            if (splitSecondHalfOnDot.Length != 2 || splitSecondHalfOnDot[0].Length == 0 || splitSecondHalfOnDot[1].Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateInt(string userInput)
        {
            int result;
            if (int.TryParse(userInput, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
