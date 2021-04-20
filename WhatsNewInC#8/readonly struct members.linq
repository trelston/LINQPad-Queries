<Query Kind="Program" />

void Main()
{
	// See https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8
}

struct Point
{
	public double Y { get; set; }
	public double X { get; set; }

	//Note the readonly modifier. This will generate a compiler error if you try and modify
	// the struct's fields within the method
	public readonly override string ToString() => $"({X},{Y}) is {Distance} from the origin";
	
	public readonly double Distance => Math.Sqrt (X*X + Y*Y);
}
