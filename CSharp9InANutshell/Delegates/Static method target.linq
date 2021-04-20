<Query Kind="Program" />

void Main()
{
	Transformer t = Test.Square;
	Console.WriteLine(t(10));
}

delegate int Transformer (int x);
	
class Test
{
	public static int Square(int x) => x * x;
}
