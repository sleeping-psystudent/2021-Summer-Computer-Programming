using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4_Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prefix = new string[7] { "0o", "乂☆", "＼", "↗", "＊*", "卍"," "};
            string[] infix = new string[8] { "a", "o", "x", "之", "★", "～", "‧"," " };
            string[] postfix = new string[7] { "o0", "☆乂", "／", "↙", "*＊", "卍"," " };
            string[] FirstWord = new string[7] { "小小", "元氣", "楓糖", "霸氣", "煞氣", "闇夜", "血" };
            string[] SecondWord = new string[6] { "糖", "漾", "戀果", "鮭魚", "鮪魚", "大閘蟹"};

            Random crandom = new Random();
            int a = crandom.Next(0,7);
            int b = crandom.Next(0,8); 
            int c = crandom.Next(0,7); 
            int d = crandom.Next(0,6);

            string id = prefix[a] + FirstWord[c] + infix[b] + SecondWord[d] + postfix[a];
            id = id.Replace(" ", "");
            Console.Write(id);
            Console.ReadKey();
        }
    }
}
