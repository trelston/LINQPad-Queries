<Query Kind="Program" />

// A delegate type may contain generic type parameters

void Main()
{
	int[] values = { 1, 2, 3};
	Util.Transform(values, Square);		// Dynamically hook in Square
	values.Dump();
}

// Define other methods and classes here
public delegate T Transformer<T> (T arg);

int Square (int x) => x * x;
//With this definition, we can write a generalized Transform utility method that works on any type
class Util
{
	public static void Transform<T> (T[] values, Transformer<T> t)
	{
		for (int i = 0; i < values.Length; i++)
		{
			values[i] = t(values[i]);
		}
	}
}