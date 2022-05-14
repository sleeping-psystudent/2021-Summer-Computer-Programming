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
            string[] number = input.Split('+', '-', '*', '/');

            char symbol='0';
            foreach(var ch in input)
            {
                switch(ch)
                {
                    case '+':
                        symbol = '+';
                        break;
                    case '-':
                        symbol = '-';
                        break;
                    case '*':
                        symbol = '*';
                        break;
                    case '/':
                        symbol = '/';
                        break;
                }
            }
            int[] n = new int[2];
            int i = 0;
            foreach(var num in number)
            {
                if (num.All(char.IsDigit))
                {
                     n[i]= Convert.ToInt32(num);
                }
                else
                {
                     n[i]= Arabic(num);
                }
                i++;
            }

            int result=0;
            if (symbol == '+')
            {
                result = n[0] + n[1];
            }
            if (symbol == '-')
            {
                result = n[0] - n[1];
            }
            if (symbol == '*')
            {
                result = n[0] * n[1];
            }
            if (symbol == '/')
            {
                result = n[0] / n[1];
            }

            if (result == 0)
            {
                Console.Write("zero");
                Console.ReadKey();
            }              
            else
                Roman(result);
        }

        static int Arabic(string number)
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
            foreach (var num in ro)
            {
                for (i = 0; i < 7; i++)
                {
                    if (num == roman[i])
                    {
                        result = arabic[i];
                        break;
                    }
                }

                if (result <= last)
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

            return sum;
        }

        static void Roman(int number)
        {
            string[] roman = new string[13] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] arabic = new int[13] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            string result = string.Empty;
            int i;
            for (i = 12; i >= 0; i--)
            {
                while (number >= arabic[i])
                {
                    number -= arabic[i];
                    result += roman[i];
                }
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
