using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Utilities
    {
        internal static string GetInput()
        {
            return Console.ReadLine();
        }

        internal static int GetIntput()
        {
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }
        internal static double GetDoubleput()
        {
            string input = Console.ReadLine();
            double result = Convert.ToDouble(input);
            return result;
        }
        internal static DateTime GetDateput()
        {
            string input = Console.ReadLine();
            DateTime result = DateTime.Parse(input);
            return result;
        }
    }
}
