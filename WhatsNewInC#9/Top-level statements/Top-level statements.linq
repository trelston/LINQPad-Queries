<Query Kind="Statements" />

/* Before C# 9, a simple "Hello, world" in Visual Studio required the following volume of code:

class Program
{
	static void Main()
	{
		System.Console.WriteLine(" Hello World");
	}
}

With C# 9, we can finally cut the clutter! A program can now comprise purely of top-level statements: */

Console.WriteLine("Hello, world");