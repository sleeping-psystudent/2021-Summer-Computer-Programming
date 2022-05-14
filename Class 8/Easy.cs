using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input NX:");
            int NX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input NY");
            int NY = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input v0");
            double v0 = double.Parse(Console.ReadLine());

            char[,] Screen = new char[NY, NX];

            for (int i = 0; i < NY; i++)
            {
                for (int j = 0; j < NX; j++)
                {
                    Screen[i, j] = ' ';
                }
            }

            int t;
            int x = 0;
            int y = 0;
            const double g = 0.1;
            double NT = Math.Sqrt((2 * NY / (double)g));

            for (t = 0; t < NT; t++)
            {
                Screen[y, x] = ' ';
                x = getHorizontalDistance(v0, t);
                y = getVerticalDistance(g, t);
                if (x >= NX || y >= NY)
                    break;
                updateScreen(x, y, NX, NY, Screen);
            }
            Console.WriteLine("Reach ground at "+NT+"s");
            Console.ReadKey();
        }
        static void updateScreen(int x, int y, int NX, int NY, char[,] screen)
        {
            screen[y, x] = 'o';
            Console.Clear();

            for (int m = 0; m < NY; m++)
            {
                for (int n = 0; n < NX; n++)
                {
                    Console.Write(screen[m, n]);
                }
                Console.WriteLine();
            }
        }
        static int getHorizontalDistance(double v0, int time)
        {
            double x = v0 * time;
            return(int) x;
        }
        static int getVerticalDistance(double gravity, int time)
        {
            double y = 0.5 * gravity * time * time;
            return(int) y;
        }
    }
}
