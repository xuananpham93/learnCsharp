using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            double tienluong, luongrong;

            Console.Write("Please enter your salary: ");
            string input_tienluong = Console.ReadLine();

            bool check = double.TryParse(input_tienluong, out tienluong);

            if (check)
            {
                if (tienluong <= 7)
                {
                    luongrong = tienluong - 0.1 * tienluong;
                    Console.WriteLine("You received :{0} VND ", luongrong);
                }
                else if (tienluong <= 15)
                {
                    luongrong = tienluong - 0.2 * tienluong;
                    Console.WriteLine("You received :{0} VND ", luongrong);
                }
                else
                {
                    luongrong = tienluong - 0.3 * tienluong;
                    Console.WriteLine("You received :{0} VND ", luongrong);
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
