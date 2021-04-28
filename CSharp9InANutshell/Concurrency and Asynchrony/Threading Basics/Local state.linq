<Query Kind="Statements" />

//The CLR assigns each thread its own memory stack so that local variables are kept separate. 
//In the next example, we define a method with a local variable and then call the method simultaneously on the main thread 
//and a newly created thread:

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

//A separate copy of the cycles variable is created on each thread’s memory stack, and so the output is, predictably, 10 question marks.