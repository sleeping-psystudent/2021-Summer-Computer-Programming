using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int N = 100;
            double[] xposition = new double[N];
            Random pick = new Random(Guid.NewGuid().GetHashCode());
            for(i = 0;i<N;i++)
            {
                xposition[i] = N*pick.NextDouble();
            }
            int maxGeneration = 1000;

            double ymin = 100; 
            double xmin = 100;
            double[] yposition = new double[N];
            for(int generation =1;generation<=maxGeneration;generation++)
            {
                for(i=0;i<N;i++)
                {
                    yposition[i] = function(xposition[i]);
                    if(yposition[i]<ymin)
                    {
                        ymin = yposition[i];
                        xmin = xposition[i];
                    }
                }
                for (i = 0; i < N; i++)
                {
                    double stepsize = (xmin - xposition[i]) * pick.NextDouble();
                    xposition[i] += stepsize;
                }

            }

            Console.WriteLine("easyPSO找到的函數極小值為" + ymin);
            Console.Write("位於x = " + xmin);
            Console.ReadKey();
        }

        static double function(double x)
        {
            double y = (Math.Pow(x, 2) / 4000)-Math.Cos(x)+1;
            return y;
        }
    }
}
