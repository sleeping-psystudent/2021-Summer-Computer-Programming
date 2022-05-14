using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            int c = int.Parse(Console.ReadLine()) ;

            int a = 1;
            int b = 0;
            int m;
            decimal n;
            for (int i=1;i<=c;i++)
            {
                if(b==0)
                {
                    n = a / 1;
                }
                else
                {
                    n = (decimal)a / b;
                }

                Console.WriteLine("F(" + i + ")=" + a + ", ratio=" +n);
                m = a + b;
                b = a;
                a = m;
            }

            Console.ReadKey();
        }
    }
}
