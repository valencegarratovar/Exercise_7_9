using System;

public class Average
{
	public static void Main()
	{
		double notesSum = 0;
		double mark;
		double count = 0;
		double noteAverage;
		string insertedWord;

		Console.Write("Insert a mark: ");
		insertedWord = Console.ReadLine();	// we read the mark as string to check the word "end"

		while (insertedWord != "end")
		{  // if the mark isn't an end then we pass it to double to work with it
			mark = Convert.ToDouble(insertedWord);
			count++;   //counter of numbers
			notesSum += mark;  // sum of all the notes
			Console.Write("Insert a mark: ");
			insertedWord = Console.ReadLine();
		}

		if (count != 0)
		{
			noteAverage = notesSum / count;  //calculate the average
			Console.WriteLine("The average is {0}.", noteAverage);
		}
	}
}
