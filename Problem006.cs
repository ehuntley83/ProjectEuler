using System;
					
public class Program
{
	public static void Main()
	{
		var sumOfAll = 0;
		var sumOfSquares = 0;
		
		for (var i = 1; i <= 100; i++)
		{
			sumOfAll += i;
			sumOfSquares += i * i;
		}
		
		Console.WriteLine((sumOfAll * sumOfAll) - sumOfSquares);
	}
}