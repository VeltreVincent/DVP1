using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1
{
    class SwapName
    {
        public static void Swap()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Swap Name!");
            

            Console.WriteLine("Please enter your first name!");
            string first = Console.ReadLine();

            Console.WriteLine("Please enter your last name!");
            string last = Console.ReadLine();

            Console.WriteLine("So, your full name is " + first + " " + last + ". Which would be " + last + " " + first + " reversed!");
            Console.WriteLine("Thank you for choosing Swap Name!");
            Console.ReadLine();
            Menu.MyMenu();
        }
    }
}
