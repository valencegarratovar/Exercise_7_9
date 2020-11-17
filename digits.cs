/*
 * (C) IES San Vicente 2020. 1ºDAM Semipresencial. Valentina Cegarra.
 * 
 * Program that ask the user to enter a number to calculate the amount of digits (1, 2, 3 o more) of the inserted number.
 * When the user enters the word "end" the program prints the number of digits. * 
 */
using System;

class digits
{
    static void Main()
    {        
        int digits1 = 0;
        int digits2 = 0;
        int digits3 = 0;
        int moreDigits = 0;
        
        Console.Write("Insert a number: ");
        string wordInserted = Console.ReadLine();

        while (wordInserted != "end")
        {
            int numberInserted = Convert.ToInt32(wordInserted);

            if (numberInserted != 0)
            {
                if (numberInserted / 10 == 0)
                    digits1++;
                else if (numberInserted / 100 == 0)
                    digits2++; 
                else if (numberInserted / 1000 == 0)
                    digits3++; 
                else
                    moreDigits++;
            }

            wordInserted = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", digits1, digits2, digits3, moreDigits); 
    }
}