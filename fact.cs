
class fact
{
	static void main(string[] args)
	{
		Console.WriteLine("Enter a number:");
		int num=Convert.ToInt32(Console.ReadLine());
		int fact = 1;
		for (int i = 1; i <= num; i++)
		{
			fact = fact * i;
		}
		Console.WriteLine(fact);
	}
}

