using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");

            string input_number = Console.ReadLine();

            bool check = int.TryParse(input_number, out number);

            if (check)
            {
                if (number > 100)
                {
                    Console.WriteLine("{0} bigger than 100", number);
                }
                else if (number == 100)
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("{0} less than 100", number);
                }
            }
            else
            {
                Console.WriteLine("You enter wrong. Please restart application !");
            }

            Console.ReadKey();
        }
    }
}
