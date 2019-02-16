using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1
{
    class Backwards
    {
        public static void Reverse()
        {
            Console.Clear();
            Console.WriteLine("You have chosen Backwards.");

            Console.WriteLine("Please enter a sentence containing at least 6 words!");
            var input = Console.ReadLine();

            foreach (var word in input.TrimEnd('.').Split('.'))
                Console.WriteLine(input.Trim().Split(' ').Count());
            Console.ReadLine();

            int x = 0;
            int.TryParse(input, out x);
            if(x < 6)
            {
                Console.WriteLine("Please enter a sentence with 6 words or more.");
                input = Console.ReadLine();
            }
            Console.WriteLine("");

            Console.WriteLine("You entered: " + input + "\r\n");

            string reverseInput = ReverseString(input);

            Console.WriteLine("The sentence you entered will be displayed Backwards now;\r\n" + reverseInput);

            


            Console.ReadLine();
            Menu.MyMenu();
        }

        public static string ReverseString(string a)
        {

            char[] array1 = a.ToCharArray();
            Array.Reverse(array1);
            return new string(array1);
        }
    }
}
