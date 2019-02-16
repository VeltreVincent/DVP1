using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1
{
    class Menu
    {
        public static void MyMenu()
        {
            Console.WriteLine("Coding Challenge Menu:");
            Console.WriteLine("Please enter a number from the list below to open a coding challenge");
            Console.WriteLine("");
            Console.WriteLine("1. Swap Name");
            Console.WriteLine("2. Backwards");
            Console.WriteLine("3. Age Converter");
            string userResponse = Console.ReadLine();

            int select;

            while(!(int.TryParse(userResponse, out select)))
            {
                Console.WriteLine("You didn't enter a valid number from the list, please try again.");
                userResponse = Console.ReadLine();

            }
            if (userResponse == "1")
            {
                SwapName.Swap();
            }
            if (userResponse == "2")
            {
                Backwards.Reverse();
            }
            if (userResponse == "3")
            {
                AgeConvert.Age();
            }
            
        }
    }
}
