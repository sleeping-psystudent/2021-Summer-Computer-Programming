using System;
using iTextSharp.text;

namespace Class2_Hard
{
    class Program
    {

        static void Main(string[] args)
        {
            string formula = Console.ReadLine();

            char[] s;
            s = formula.ToCharArray();

            int a = (int)Char.GetNumericValue(s[0]);
            int b = (int)Char.GetNumericValue(s[2]);

            if (s[1]=='+')
            {
                Console.WriteLine(a+b);
            }
            else if(s[1]=='-')
            {
                Console.WriteLine(a-b);
            }
            else if (s[1] == '*')
            {
                Console.WriteLine(a*b);
            }
            else if (s[1] == '/')
            {
                Console.WriteLine(a/b);
            }

            
        }

        
    }
}
