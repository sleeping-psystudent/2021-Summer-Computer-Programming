using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=100;i<=999;i++)
            {
                int a = i % 10;
                int b = (i / 10) % 10;
                int c = i /100;


                if (i==Math.Pow(a, 3)+ Math.Pow(b, 3)+ Math.Pow(c, 3))
                {
                    Console.WriteLine(i+ " is a 3-narcissistic number");
                }
            }
            Console.ReadKey();

        }
    }
}
