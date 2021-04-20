<Query Kind="Statements" />

void WriteY()
{
	for (int i = 0; i < 1000; i++)
	{
		Console.WriteLine("y");
	}
}

Thread t = new Thread(WriteY);	//Kickoff a new thread
t.Start();						//Running WriteY

//Simultaneously do something on the main thread
for (int i = 0; i < 1000; i++)
{
	Console.WriteLine("x");
}
