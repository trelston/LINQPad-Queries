<Query Kind="Statements" />

void Go()
{
	for (int i = 0; i < 1000; i++)
	{
		Console.WriteLine("y");
	}
}

Thread t = new Thread(Go);
t.Start();
t.Join();
Console.WriteLine("Thread t has ended!");