using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Demo
{
    internal class Methods
    {
        public static void IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }

        public static int Add(int num1, int num2)
        {
            return 10; 
        }

        public static List<string> GetAllGamingConsoles()
        {
            List<string> gamingConsoles = new List<string>();
            gamingConsoles.Add("xbox");
            gamingConsoles.Add("ps5");
            return gamingConsoles;
        }
    }
}
