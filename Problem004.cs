/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/

using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var max = 0;

		for (var i = 100; i < 1000; i++)
		{
			for (var j = i + 1; j < 1000; j++)
			{
				var product = i * j;
				var str = (product).ToString();
				var reversed = new String(str.ToCharArray().Reverse().ToArray());
				if (str == reversed && product > max)
					max = product;
			}
		}
		
		Console.WriteLine(max);
	}
}