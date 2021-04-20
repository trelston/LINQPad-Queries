<Query Kind="Expression" />

void Main()
{
	int y = 5;
	int x = 7;
	Add(x, y).Dump();

	// The static keyword means we can't access local variables (x and y):
	static int Add(int left, int right) => left + right;
}