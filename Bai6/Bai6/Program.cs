using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double doanhso, hoahong;
            Console.Write("Please enter total sales: ");
            string input_doanhso = Console.ReadLine();

            bool check = double.TryParse(input_doanhso, out doanhso);

            if (check)
            {
                if (doanhso <= 100)
                {
                    hoahong = 0.05 * doanhso;
                    Console.WriteLine("Your commission : " + hoahong);
                }
                else if (doanhso <= 300)
                {
                    hoahong = 0.1 * doanhso;
                    Console.WriteLine("Your commission : " + hoahong);
                }
                else
                {
                    hoahong = 0.2 * doanhso;
                    Console.WriteLine("Your commission : " + hoahong);
                }
            }
            else
            {
                Console.WriteLine("You have enterd wrong. Please restart application");
            }


            Console.ReadKey();
        }
    }
}
