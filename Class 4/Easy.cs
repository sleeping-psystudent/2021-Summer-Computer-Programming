using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a range: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) 
            {
                int b=1;
                while(b!=num-i+1)
                {
                   Console.Write(" ");
                    b++;
                }
                int a = 1;
                while (a < i)
                {
                   Console.Write(a);
                   a++;
                }
                while (a >=1)
                {
                    Console.Write(a);
                    a--;
                }
                Console.Write("\r\n");
            }

            Console.ReadKey();
         }
    }
}
