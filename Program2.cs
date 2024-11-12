using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int a;
            
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(fact(a));
            Console.WriteLine("Press To Continue...");
            Console.ReadKey();
        }

        static int fact(int a)
        {
            int sum;
            if (a != 0 || a > 0)
            {
                sum = a * fact(a - 1);
            }
            else
            {
                return 1;
            }
            return sum;
        }
    }
}
