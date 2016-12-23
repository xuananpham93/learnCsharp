using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, kq;

            Console.WriteLine("The equation: ax2 + bx + c = 0");
            Console.Write("Please enter number a: ");
            string input_a = Console.ReadLine();

            Console.Write("Please enter number b: ");
            string input_b = Console.ReadLine();

            Console.Write("Please enter number c: ");
            string input_c = Console.ReadLine();

            bool check1 = float.TryParse(input_a, out a);
            bool check2 = float.TryParse(input_b, out b);
            bool check3 = float.TryParse(input_c, out c);

            if (check1 && check2 && check3)
            {
                float delta = b*b - 4*a*c;

                if (delta < 0)
                {
                    Console.WriteLine("The equation has no solution");
                } else if (delta == 0)
                {
                    kq = -b / (2*a);
                    Console.WriteLine("The equation have dual experience x1 = x2 = {0}", kq);
                }
                else
                {
                    double kq1 = (-b + Math.Sqrt(25)) / (2 *a);
                    double kq2 = (-b - Math.Sqrt(25)) / (2 * a);
                    Console.WriteLine("The equation have x1 = {0}, x2 = {1}", kq1, kq2);
                }
            }
            else
            {
                Console.WriteLine("You have entered wrong. Please restart application");
            }

            Console.ReadKey();
        }
    }
}
