using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    public static class InputLibrary
    {
        public static string UserInputString()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
        public static decimal UserInputToDecimal()
        {
            decimal userInputToDecimal = Convert.ToDecimal(Console.ReadLine());

            // write an exeption forr error

            return userInputToDecimal;
        }

        public static int UserInputToInt()
        {
            int userInputToInt = Convert.ToInt32(Console.ReadLine());

            return userInputToInt;
        }
    }
}
