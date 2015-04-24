/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var primes = PrimeSeive(2000000);

        long sum = primes.Aggregate<int, long>(0, (current, prime) => current + prime);

        Console.WriteLine(sum);
        Console.ReadLine();
    }

    public static List<int> PrimeSeive(int max)
    {
        var primeCandidates = Enumerable.Range(2, max).ToList();

        var sqrtOfMax = Math.Sqrt(max);
        var cur = 1;

        while (cur <= sqrtOfMax)
        {
            cur = primeCandidates.First(i => i > cur);
            primeCandidates.RemoveAll(i => i != cur && i % cur == 0);
        }

        return primeCandidates;
    }
}