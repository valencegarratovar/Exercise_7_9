using System;

public class Average
{
	public static void Main()
	{
		double a = 0;
		double b;
		double c = 0;
		double d;
		string s;

		Console.Write("Insert a mark: ");
		s = Console.ReadLine();	// we read the mark as string to check the word "end"

		while (s != "end")
		{  // if the mark isn't an end then we pass it to double to work with it
			b = Convert.ToDouble(s);
			c++;   //counter of numbers
			a += b;  // sum of all the notes
			Console.Write("Insert a mark: ");
			s = Console.ReadLine();
		}

		if (c != 0)
		{
			d = a / c;  //calculate the average
			Console.WriteLine("The average is {0}.", d);
		}
	}
}
