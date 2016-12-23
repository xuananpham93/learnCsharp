using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, max;
            Console.Write("Please enter number 1: ");
            string input_number1 = Console.ReadLine();

            Console.Write("Please enter number 2: ");
            string input_number2 = Console.ReadLine();

            Console.Write("Please enter number 3: ");
            string input_number3 = Console.ReadLine();

            bool check1 = int.TryParse(input_number1, out number1);
            bool check2 = int.TryParse(input_number2, out number2);
            bool check3 = int.TryParse(input_number3, out number3);

            if (check1 && check2 && check3)
            {
                if (number1 > number2)
                {
                    max = number1;
                }
                else
                {
                    max = number2;
                }

                if (max < number3)
                {
                    max = number3;
                }

                Console.WriteLine("Largest number is: " + max);
            }   
            else
            {
                Console.WriteLine("You have entered wrong. Please restart application");
            }

            Console.ReadKey();
        }
    }
}
