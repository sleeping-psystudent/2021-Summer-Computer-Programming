using System;
using System.Text;


namespace randomPassword
{
    class program
    {
		static void Main(string[] args)  
    	{  
			int numbers()
			{
				Random random = new Random();
				int num = random.Next(10);
				return num;
			}
			string capitalAlphabets()
			{
				Random random = new Random();
				int num = random.Next(65, 91);
				string capitalAlphabets = Convert.ToChar(num).ToString();
				return capitalAlphabets;
			}
			string smallAlphabets()
			{
				Random random = new Random();
				int num = random.Next(97, 123);
				string smallAlphabets = Convert.ToChar(num).ToString();
				return smallAlphabets;
			}
			string others()
			{
				Random random = new Random();
				int num = random.Next(33, 47);
				string others = Convert.ToChar(num).ToString();
				return others;
			}
			StringBuilder password = new StringBuilder();
			Random random = new Random();
			int length = random.Next(14, 20);
			for (int i = 0; i < length; i++)
			{
				Random ran = new Random();
				switch (ran.Next(4))
				{
					case 0:
					password.Append(numbers());
					break;
					case 1:
					password.Append(capitalAlphabets());
					break;
					case 2:
					password.Append(smallAlphabets());
					break;
					case 3:
					password.Append(others());
					break;
				}
			}
			Console.WriteLine("Your random password is: " + Environment.NewLine + password.ToString());  
    	}

    }
}

