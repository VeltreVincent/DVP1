using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP1
{
    class AgeConvert
    {
        public static void Age()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Age Converter!");
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            while((string.IsNullOrWhiteSpace(name)))
            {
                Console.WriteLine("Please enter your name, thank you.");
                name = Console.ReadLine();
            }
            
            Console.WriteLine("Hello " + name + ". What is your age?");
            string stringAge = Console.ReadLine();
            int age;

            while(!(int.TryParse(stringAge, out age)))
            {
                Console.WriteLine("Please enter a valid number for your age.");
                stringAge = Console.ReadLine();
            }

            Console.WriteLine("So " + name + " you entered " + age + ", thank you.\r\n");


            int day = Days(age);
            int hour = Hours(age);
            int minute = Minutes(age);
            int second = Seconds(age);

            Console.WriteLine("The next time someone askes how old you are, tell them;\r\nI am " + day + " days old.\r\nI am " + hour + " hours old.\r\nI am " + minute + " minutes old.\r\nI am " + second + " seconds old.");


            Console.ReadLine();
            Menu.MyMenu();
        }

        public static int Days(int a)
        {
            a = a * 365;
            return a;
        }
        public static int Hours(int b)
        {
            b = b * 8760;
            return b;
        }
        public static int Minutes(int c)
        {
            c = c * 525600;
            return c;
        }
        public static int Seconds(int d)
        {
            d = d * 31536000;
            return d;
        }
    }
}
