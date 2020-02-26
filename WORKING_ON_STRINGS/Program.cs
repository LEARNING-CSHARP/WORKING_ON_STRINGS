namespace WORKING_ON_STRINGS
{
	internal static class Program
	{
		static Program()
		{
		}

		static void Main()
		{
			// **************************************************
			//string source = "Hello, World!";
			//string target = source.ToUpper();

			//System.Console.WriteLine($"Target: [{ target }]");

			// Outout: Target: HELLO, WORLD!
			// **************************************************

			// **************************************************
			//string source = "Hello, World!";
			//string target = source.ToLower();

			//System.Console.WriteLine($"Target: [{ target }]");

			// Outout: Target: hello, world!
			// **************************************************

			// **************************************************
			//string source = "   Hello, World!     ";
			//string target = source.TrimStart();

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Hello, World!     
			// **************************************************

			// **************************************************
			//string source = "   Hello, World!     ";
			//string target = source.TrimEnd();

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target:    Hello, World!
			// **************************************************

			// **************************************************
			//string source = "   Hello, World!     ";
			//string target = source.TrimStart().TrimEnd();
			//string target = source.TrimEnd().TrimStart();

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Hello, World!
			// **************************************************

			// **************************************************
			//string source = "   Hello, World!     ";
			//string target = source.Trim();

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Hello, World!
			// **************************************************

			// **************************************************
			//string source = "Hello, Ali! How are you Ali?";
			//string target = source.Replace("Ali", "Dariush");

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Hello, Dariush! How are you Dariush?
			// **************************************************

			// **************************************************
			//string source = "Dariush Tasdighi";

			//if(source.StartsWith("Dariush"))
			//{
			//	System.Console.WriteLine("The string starts with Dariush!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not start with Dariush!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Dariush Tasdighi";

			//if (source.StartsWith("Ali"))
			//{
			//	System.Console.WriteLine("The string starts with Ali!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not start with Ali!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Dariush Tasdighi";

			//if (source.EndsWith("Tasdighi"))
			//{
			//	System.Console.WriteLine("The string ends with Tasdighi!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not end with Tasdighi!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Dariush Tasdighi";

			//if (source.EndsWith("Alavi"))
			//{
			//	System.Console.WriteLine("The string ends with Alavi!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not end with Alavi!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Ali Reza Alavi";

			//if (source.Contains("Ali"))
			//{
			//	System.Console.WriteLine("The string contains Ali!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not contain Ali!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Ali Reza Alavi";

			//if (source.Contains("Reza"))
			//{
			//	System.Console.WriteLine("The string contains Reza!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not contain Reza!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Ali Reza Alavi";

			//if (source.Contains("Alavi"))
			//{
			//	System.Console.WriteLine("The string contains Alavi!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not contain Alavi!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Ali Reza Alavi";

			//if (source.Contains("za Al"))
			//{
			//	System.Console.WriteLine("The string contains za Al!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not contain za Al!");
			//}
			// **************************************************

			// **************************************************
			//string source = "Ali Reza Alavi";

			//if (source.Contains("Dariush"))
			//{
			//	System.Console.WriteLine("The string contains Dariush!");
			//}
			//else
			//{
			//	System.Console.WriteLine("The string does not contain Dariush!");
			//}
			// **************************************************

			// **************************************************
			// Note: Wrong Solution!

			//string source = "  Ali  Reza  Alavi  "; // "Ali Reza Alavi"
			//string target = source.Trim();

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Ali  Reza  Alavi
			// **************************************************

			// **************************************************
			// Note: Wrong Solution!

			//string source = "  Ali  Reza  Alavi  "; // "Ali Reza Alavi"
			//string target = source.Replace(" ", "");

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: AliRezaAlavi
			// **************************************************

			// **************************************************
			// Note: Wrong Solution!

			//string source = "  Ali   Reza  Alavi  "; // "Ali Reza Alavi"

			//string target = source.Trim().Replace("  ", " ");

			//string target = source.Trim().Replace("   ", " ").Replace("  ", " ");

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Ali Reza Alavi
			// **************************************************

			// **************************************************
			//string source = "        Ali               Reza      Alavi          "; // "Ali Reza Alavi"
			//string target = source.Trim();

			//while (target.Contains("  "))
			//{
			//	target = target.Replace("  ", " ");
			//}

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: Ali Reza Alavi
			// **************************************************

			// **************************************************
			//string source = "Hello";
			//string target =
			//	source.PadLeft(totalWidth: 10, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [*****Hello]
			// **************************************************

			// **************************************************
			//string source = "Hello";
			//string target =
			//	source.PadLeft(totalWidth: 5, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [Hello]
			// **************************************************

			// **************************************************
			// هیچ تاثیری ندارد

			//string source = "Hello";
			//string target =
			//	source.PadLeft(totalWidth: 3, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [Hello]
			// **************************************************

			// **************************************************
			//string source = "Hello";
			//string target =
			//	source.PadRight(totalWidth: 10, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [Hello*****]
			// **************************************************

			// **************************************************
			//string source = "Hello";
			//string target =
			//	source.PadRight(totalWidth: 5, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [Hello]
			// **************************************************

			// **************************************************
			// هیچ تاثیری ندارد

			//string source = "Hello";
			//string target =
			//	source.PadRight(totalWidth: 3, paddingChar: '*');

			//System.Console.WriteLine($"Target: [{ target }]");

			//Outout: Target: [Hello]
			// **************************************************

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
