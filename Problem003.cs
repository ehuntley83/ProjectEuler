/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143?
*/

/*
NOTE: This solution uses Trial Division to find prime factors because it's easy to understand :p
Ref: http://en.wikipedia.org/wiki/Trial_division
*/

using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var target = 600851475143;
		var primes = PrimeSeive(10000);
		
		var primeFactors = new List<long>();		
		foreach (var prime in primes.Where(i => i * i < target))
		{
			while (target % prime == 0)
			{
				primeFactors.Add(prime);
				target /= prime;
			}
		}
		
		if (target > 1)
			primeFactors.Add(target);
		
		Console.WriteLine(primeFactors.Max());
		foreach (var pf in primeFactors)
			Console.Write(pf + " ");
	}
	
	public static List<int> PrimeSeive(int max)
	{
		var primeCandidates = Enumerable.Range(2, max).ToList();
		
		var sqrtOfMax = Math.Sqrt(max);
		var cur = 1;	
		
		while(cur <= sqrtOfMax)
		{
			cur = primeCandidates.First(i => i > cur);
			primeCandidates.RemoveAll(i => i != cur && i % cur == 0);
		}
		
		return primeCandidates;
	}
}