// you can also use other imports, for example:
using System;
using System.Text.RegularExpressions;
using System.Linq;

					
public class Program
{
	private static int BinaryGap(int n)
	{
       var regex = Regex.Matches(Convert.ToString(n, 2), @"(0+)(?:1+)");
		if (regex.Count <= 0) return 0;
		
		return regex.Cast<Match>().Max(m => m.Groups[1].Value.Length);
		
	}
	
	public static void Main()
	{
		Console.WriteLine(BinaryGap(1041));		
		Console.WriteLine(BinaryGap(529));		
		Console.WriteLine(BinaryGap(3));
		Console.WriteLine(BinaryGap(32));
	}
}
