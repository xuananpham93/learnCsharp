using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double sophut, tientra;
            const int cost = 25000;

            Console.Write("Please enter number of minutes used: ");
            string input_sophut = Console.ReadLine();

            bool check = double.TryParse(input_sophut, out sophut);

            if (check)
            {
                if (sophut <= 50)
                {
                    tientra = 600 * sophut + cost;
                    Console.WriteLine("You must pay :{0} VND " ,tientra);
                }
                else if (sophut <= 150)
                {
                    tientra = 400 * sophut + cost;
                    Console.WriteLine("You must pay :{0} VND ", tientra);
                }
                else
                {
                    tientra = 200 * sophut + cost;
                    Console.WriteLine("You must pay :{0} VND ", tientra);
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
