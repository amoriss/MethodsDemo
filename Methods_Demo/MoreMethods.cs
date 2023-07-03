using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Demo;
internal class MoreMethods
{
    public static float MetersToMiles (float meters)
    {
        return meters * 0.000621371f;      

    }

    public static bool GreatestNumber(int number1, int number2)
    {
        
        if (number1 > number2)
        {
            return true;
        }
        else
        {
            return false; 
        }
      
        
    }
    public static string DoesSomething()
    {
        Console.WriteLine("this method does something");
        return "";
       
    }

}
