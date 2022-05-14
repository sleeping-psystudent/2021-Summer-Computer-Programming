using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3_Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter num1 : ");
            int a = int.Parse(Console.ReadLine());
            int c = a;
            Console.Write("Please enter num2 : ");
            int b = int.Parse(Console.ReadLine());
            int d = b;

            if (c > 0 && d > 0)
            {
                if(a<b)
                {
                    a = d;
                    b = c;
                }
                int m;
                while (b!=0)
                {
                    m = a % b;
                    a = b;
                    b = m;
                }
                Console.WriteLine("The Greatest Common Divisor of "+c+" and "+d+" is "+ a);
                Console.WriteLine("The Least Common Multiple of " + c + " and " + d + " is " + (c*d/a));
            }
            else
            {
                Console.WriteLine("Value Out of Range.");
            }

            Console.ReadKey();

        }
    }
}
