<Query Kind="Program" />

// A delegate type declaration is like an abstract method declaration, prefixed with the delegate keyword.
// To create a delegate instance, assign a method to a delegate variable.
delegate int Transformer(int x); // Our delegate type declaration

int Square (int x) => x * x;

void Main()
{
	//Create a delegate instance
	Transformer t = Square;
	
	//Invoke delegate
	int result = t(3);
	
	Console.WriteLine(result);
}



