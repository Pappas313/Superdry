using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superdry
{
    internal static class Input
    {
       
        internal static int IntInput()
        {
            string input = Console.ReadLine();
            int output;

            while (!int.TryParse(input, out output))
            {

                try
                {
                    output = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You inserted an invalid number!");


                }
                catch (OverflowException)
                {
                    Console.WriteLine("You inserted a very long number!");
                }
                Console.Write("Enter a valid integer number: ");
                input = Console.ReadLine();
            }
            return output;
        }

        internal static DateTime DateInput()
        {
            string date = Console.ReadLine();
            DateTime correctDate;
            while (!DateTime.TryParseExact(date, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out correctDate))
            {
                Console.WriteLine("Invalid data input!");
                Console.Write("The date must be written like \"d / M / yyyy\"): ");
                date = Console.ReadLine();
            }
            return correctDate;
        }



    }
}
