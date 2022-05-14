using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7_Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input height of the Pascal's triangle: ");
            int layer = int.Parse(Console.ReadLine());

            int[,] pascal = new int[layer+1, layer+1];
            int sum = 0;
            for(int i = 1; i<=layer; i++)
            {
                for(int j = 1;j<=layer-1;j++)
                {
                    if(j != 1)
                    {
                        pascal[i, j] = pascal[i - 1, j-1] + pascal[i - 1, j];
                    }
                    else if(j==1)
                    {
                        pascal[i, j] = 1;
                        pascal[i, i] = 1;
                    }
                }

                for(int m = 1; m<=i; m++)
                {
                    sum += pascal[i, m];
                }
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
