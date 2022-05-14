using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入用電度數：");
            int num = int.Parse(Console.ReadLine());

            int[] power = new int[6] { 0, 120, 330, 500, 700, 1000 };
            double[] summerrate = new double[6] { 1.63, 2.38, 3.52, 4.80, 5.66, 6.41 };
            double price = 0;
            int i = 1;

            while (num > 0)
            {
                int n = num - power[i];
                if (n >= 0 && i != 5)
                {
                    price = price + (power[i] - power[i - 1]) * summerrate[i - 1];
                }
                else if (n < 0)
                {
                    price = price + (num - power[i - 1]) * summerrate[i - 1];
                    break;
                }
                else if (n >= 0 && i == 5)
                {
                    price = price + (num - power[i]) * summerrate[i - 1];
                    break;
                }
                i++;
            }
            Console.WriteLine("當月電費為" + Convert.ToInt16(Math.Ceiling(price)) + "元");

            Console.Write("請輸入付款金額：");
            int pay = int.Parse(Console.ReadLine());

            int change = pay - Convert.ToInt16(Math.Ceiling(price));
            Console.WriteLine("應找" + change + "元");

            int[] cash = new int[7] { 1000, 500, 100, 50, 10, 5, 1 };
            string[] currency = new string[4] { "紙鈔", "硬幣", "張", "枚" };
            int j = 0;
            while (change>0)
            {
                int output = change / cash[j];
                if(j==0 || j==1 ||j==2)
                {
                    if (output != 0)
                    {
                        Console.WriteLine(cash[j] + "元" + currency[0] + output + currency[2]);
                    }
                }
                else
                {
                    if (output != 0)
                    {
                        Console.WriteLine(cash[j] + "元" + currency[1] + output + currency[3]);
                    }
                }
                change = change - cash[j] * output;
                j++;
            }

            Console.ReadKey();

        }
    }
}
