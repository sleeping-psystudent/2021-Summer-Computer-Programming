using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if(input.All(char.IsDigit))
            {
                Roman(input);
            }
            else
            {
                Arabic(input);
            }
        }

        static void Arabic(string number)
        {
            char[] roman = new char[7] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] arabic = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };

            char[] ro = number.ToCharArray();

            int result = 0;
            int last = 0;
            int sum = 0;
            int backup = 0;
            int i;
            int j = 0;
            foreach(var num in ro)
            {
                for(i = 0;i<7;i++)
                {
                    if (num == roman[i])
                    {
                        result = arabic[i];
                        break;
                    }
                }
                
                if (result<=last)
                    sum += last;
                else
                    sum -= last;

                backup = last;
                last = result;
                j++;
            }

            if (result >= backup)
                sum += result;
            else
                sum -= result;

            Console.Write(sum);
            Console.ReadKey();
        }

        static void Roman(string number)
        {
            string[] roman = new string[13] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] arabic = new int[13] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            int n = Convert.ToInt32(number);

            string result = string.Empty;
            int i;
            for(i=12;i>=0;i--)
            {
                while(n >= arabic[i])
                {
                    n -= arabic[i];
                    result += roman[i];
                }
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}