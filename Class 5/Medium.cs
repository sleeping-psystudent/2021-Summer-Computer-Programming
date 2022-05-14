using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + "=");
            List<int> arr = new List<int>();

            int i = 0;
            int prime = 2;
            while(n >=prime)
            { 
                while(n%prime==0)
                {
                    n = n / prime;
                    arr.Add(prime);
                    i++;
                }
                prime++;
            }

            int[] ans = arr.ToArray();

            for(int j=0;j<=i;j++)
            {
                if(j!=i-1)
                {
                    Console.Write(ans[j] + "*");
                }
                else if(j==i-1)
                {
                    Console.Write(ans[j]);
                }
            }

            Console.ReadKey();
        }
    }
}
