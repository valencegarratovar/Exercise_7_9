/*
 * (C) IES San Vicente 2020. 1ºDAM Semipresencial. Valentina Cegarra.
 * 
 * Program that ask the user to enter the marks in order to calculate the note average.
 * When the user enters the word "end" the program finish and prints the average. * 
 */
using System;

public class Average
{
	public static void Main()
	{
		double notesSum = 0;
		double mark;
		double notesCount = 0;
		double noteAverage;
		string insertedWord;

		Console.Write("Insert a mark: ");
		insertedWord = Console.ReadLine();	

		while (insertedWord != "end")
		{  
			mark = Convert.ToDouble(insertedWord);
			notesCount++;   
			notesSum += mark;

			Console.Write("Insert a mark: ");
			insertedWord = Console.ReadLine();
		}

		if (count != 0)
		{
			noteAverage = notesSum / notesCount; 
			Console.WriteLine("The average is {0}.", noteAverage);
		}
	}
}
