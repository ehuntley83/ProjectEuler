/*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?
*/

using System;

public class Program
{
    public static void Main()
    {
        long maxCount = 0;
        long maxStart = 0;
        for (var i = 1; i <= 1000000; i++)
        {
            var items = 1;
            long counter = i;
            while (counter != 1)
            {
                if ((counter % 2) == 0)
                    counter = counter / 2;
                else
                    counter = counter * 3 + 1;

                items++;
            }

            if (items > maxCount)
            {
                maxCount = items;
                maxStart = i;
            }
        }

        Console.WriteLine(maxCount);
        Console.WriteLine(maxStart);

        Console.ReadLine();
    }
}