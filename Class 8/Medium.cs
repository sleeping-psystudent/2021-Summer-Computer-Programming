using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8_Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input NX:");
            int NX = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input NY");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input player velocity V");
            double V = double.Parse(Console.ReadLine());

            Random random = new Random();
            double v0 = Math.Round(random.NextDouble() * (5.0 - 0.5) + 0.5, 1);

            double u1 = 1.0 - random.NextDouble(); 
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *Math.Sin(2.0 * Math.PI * u2);
            int NY = Convert.ToInt32((3 * Y / 4) + (Y / 12) * randStdNormal);

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
            int NT = (int)Math.Sqrt((2 * NY / (double)g));
            int xPlayer = 0;
            char symbol = 'o';

            for (t = 0; t <= NT; t++)
            {
                Screen[NY - 1, xPlayer] = ' ';
                Screen[y, x] = ' ';

                xPlayer = Convert.ToInt32(V * t);
                x = getHorizontalDistance(v0, t);
                y = getVerticalDistance(g, t);
                if (x >= NX || y >= NY)
                    break;
                updateScreen(symbol, xPlayer, x, y, NX, NY, Screen);
                
            }

            
            if (catchBall(x, xPlayer)==true) Console.WriteLine("Catch the ball!");
            else Console.WriteLine("Cannot catch the ball!");

            Console.ReadKey();
        }
        static void updateScreen(char symbol,int xp, int x, int y, int NX, int NY, char[,] screen)
        {
            screen[NY - 1, xp] = 'I';
            screen[y, x] = symbol;
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
            return (int)x;
        }
        static int getVerticalDistance(double gravity, int time)
        {
            double y = 0.5 * gravity * time * time;
            return (int)y;
        }
        static bool catchBall(int xBall, int xPlayer)
        {
            if (xBall == xPlayer)
                return true;
            else
                return false;

        }
    }
}
