/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/

using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var ints = from num in Enumerable.Range(1, 999) where num % 3 == 0 || num % 5 == 0 select num;
		
		Console.WriteLine(ints.Sum());
		
		var newInts = Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i  % 5 == 0).Select(i => i);
		
		Console.WriteLine(newInts.Sum());
	}
}