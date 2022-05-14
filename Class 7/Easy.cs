using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            string baseorder = Console.ReadLine();
            string[] bases = baseorder.Split(' ');
            Console.WriteLine("Enter fruit:");
            string fruitorder = Console.ReadLine();
            string[] fruits = fruitorder.Split(' ');

            Console.WriteLine("Menu:");
            int i = 0;
            foreach (var bas in bases)
            {
                int j = 0;
                foreach(var fruit in fruits)
                {
                    Console.Write(fruits[i]+bases[j]+" ");
                    j++;
                }
                Console.Write("\n");
                i++;
            }

            Console.ReadKey();
        }
    }
}
