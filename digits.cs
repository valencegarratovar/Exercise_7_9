using System;

class digits
{
    static void Main()
    {
        //counters of number of digits a is for one digit, b is for 2 digits, c is for 3 digits and d is for more than 3 digits
        int digits1 = 0;
        int digits2 = 0;
        int digits3 = 0;
        int moreDigits = 0;

        // read the number as string to check the word "end"
        Console.Write("Insert a number: ");
        string wordInserted = Console.ReadLine();

        while (wordInserted != "end")
        {
            int numberInserted = Convert.ToInt32(wordInserted);

            if (numberInserted != 0)
            {
                if (numberInserted / 10 == 0)
                    digits1++;  // it only has one digit
                else if (numberInserted / 100 == 0)
                    digits2++;  // the number has 2 digits
                else if (numberInserted / 1000 == 0)
                    digits3++;  // the number has 3 digits
                else
                    moreDigits++;  // the number has more than 3 digits
            }

            wordInserted = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", digits1, digits2, digits3, moreDigits); 
    }
}