/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

using System;
					
public class Program
{
	public static void Main()
	{
		var num = 20;
		
		while(true)
		{
			var found = false;
			for (var i = 2; i <= 20; i++)
			{
				if (num % i != 0)
					break;
				
				if (i == 20)
					found = true;
			}
			
			if (found)
				break;
			
			num += 20;
		}
		
		Console.WriteLine(num);
	}
}