using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            float ktra, giuaky, cuoiky;
            float kq;

            Console.Write("Enter test mark: ");
            string input_ktra = Console.ReadLine();

            Console.Write("Enter test mid term: ");
            string input_giuaky = Console.ReadLine();

            Console.Write("Enter test end term: ");
            string input_cuoiky = Console.ReadLine();

            bool check1 = float.TryParse(input_ktra, out ktra);
            bool check2 = float.TryParse(input_giuaky, out giuaky);
            bool check3 = float.TryParse(input_cuoiky, out cuoiky);

            if (check1 && check2 && check3)
            {
                
                if (ktra < 0 || giuaky < 0 || cuoiky < 0)
                {
                    Console.WriteLine("Do not enter negative number. Please try again");
                }
                else
                {
                    kq = (ktra + giuaky + cuoiky) / 3;

                    if(kq >= 8)
                    {
                        Console.WriteLine("The rank is good");
                    }
                    else if (kq >=6.5)
                    {
                        Console.WriteLine("The rank is rather");
                    }
                    else if (kq >= 5)
                    {
                        Console.WriteLine("The rank is medium");
                    }
                    else
                    {
                        Console.WriteLine("The rank is weak");
                    }
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
