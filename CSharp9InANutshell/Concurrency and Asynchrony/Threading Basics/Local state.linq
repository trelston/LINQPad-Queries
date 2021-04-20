<Query Kind="Statements" />

void Go()
{
	// Declare and use a local variable - 'cycles'
	for (int cycles = 0; cycles < 5; cycles++)
	{
		Console.WriteLine("?");
	}
}

new Thread(Go).Start();      // Call Go() on a new thread
Go();                         // Call Go() on the main thread


