using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Please enter your age: ");
            string input_age = Console.ReadLine();

            bool check = int.TryParse(input_age, out age);

            if (check)
            {
                if (age >= 15 )
                {
                    Console.WriteLine("You can learn class 10");
                }
                else
                {
                    Console.WriteLine("You are not eligible");
                }
            }
            else
            {
                Console.WriteLine("You must enter a number. Please restart program !");
            }

            Console.ReadKey();
        }
    }
}
