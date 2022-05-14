using System;

namespace Class2-Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string SeniorStudentString = "senior student";
            string JuniorStudentString = "junior student";
            int MyGrade = int.Parse(Console.ReadLine());
            decimal GPA = 4.3m;
            bool G = MyGrade> 2;

            if (G != true)
            {
                Console.WriteLine("I am " + JuniorStudentString+" at NTU, and my target GPA of this semester is" + GPA);
            }
            else
            {
                Console.WriteLine("I am " + SeniorStudentString+" at NTU, and my target GPA of this semester is" + GPA);
            }

            
        }
    }
}
