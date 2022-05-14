using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入月份：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("請輸入用電度數：");
            int num = int.Parse(Console.ReadLine());

            int[] power = new int[6] {0, 120, 330, 500, 700, 1000};
            double[] summerrate = new double[6] { 1.63, 2.38, 3.52, 4.80, 5.66, 6.41 };
            double[] nonsummerrate = new double[6] { 1.63, 2.10, 2.89, 3.94, 4.60, 5.03 };
            double pay = 0;
            int i = 1;

            if ( month >= 6 && month < 10)
            {
                while(num>0)
                {
                    int n = num - power[i];
                    if (n >= 0 && i != 5)
                    {
                        pay = pay + (power[i] - power[i - 1]) * summerrate[i - 1];
                    }
                    else if (n < 0)
                    {
                        pay = pay + (num - power[i - 1]) * summerrate[i - 1];
                        break;
                    }
                    else if (n >= 0 && i == 5)
                    {
                        pay = pay + (num - power[i]) * summerrate[i - 1];
                        break;
                    }
                    i++;
                }
            }
            else
            {
                while (num > 0)
                {
                    int n = num - power[i];
                    if (n >= 0 && i!=5)
                    {
                        pay = pay + (power[i]-power[i-1]) * nonsummerrate[i-1];
                    }
                    else if (n < 0)
                    {
                        pay = pay + (num-power[i-1]) * nonsummerrate[i-1];
                        break;
                    }
                    else if (n >= 0 && i == 5)
                    {
                        pay = pay + (num -power[i]) * nonsummerrate[i-1];
                        break;
                    }
                    i++;
                }
            }
            Console.WriteLine("當月電費為" + pay + "元");
            Console.ReadKey();
        }
    }
}
