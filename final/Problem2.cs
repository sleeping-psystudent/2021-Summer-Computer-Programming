using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input_params = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int date_in_month = input_params[0];
            int first_day = input_params[1];
            string[] calendar = new string[date_in_month + first_day - 1];
            SetCalendar(calendar, date_in_month, first_day);//設定小日曆陣列 
            PrintCalendar(calendar);//顯示小日曆 
        }

        static void SetCalendar(string[] calendar,int date_in_month,int first_day)
        {
            int i;
            for(i=0;i<first_day-1;i++)
            {
                calendar[i] = " ";
            }

            int j = 1;
            for(i=first_day-1;i< date_in_month + first_day - 1;i++)
            {
                calendar[i] = Convert.ToString(j);
                j++;
            }
        }

        static void PrintCalendar(string[] calendar)
        {
            int i=0;
            foreach(string num in calendar)
            {
                Console.Write(calendar[i].PadLeft(3)+" ");
                if(i%7==6)
                {
                    Console.WriteLine();
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
