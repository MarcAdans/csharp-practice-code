// you can also use other imports, for example:
using System;
using System.Text.RegularExpressions;
using System.Linq;

//Codility_
//BinaryGap - https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

public class Program
{
	private static int BinaryGap(int n)
	{
		var match = Regex.Matches(Convert.ToString(N, 2), @"(0+)(?:1)");

		if (match.Count <= 0) return 0;

		return match.Cast<Match>()
			    .Where(m=> m.Groups.Count >= 2)
			    .Max(m => m.Groups[1].Value.Length) ;
		
	}
	
	public static void Main()
	{
		Console.WriteLine(BinaryGap(1041));		
		Console.WriteLine(BinaryGap(529));		
		Console.WriteLine(BinaryGap(3));
		Console.WriteLine(BinaryGap(32));
	}
}
