<Query Kind="Program" />

//Any try/catch/finally blocks in effect when a thread is created are of no relevance to the thread when it starts executing.
static void Main()
{
	try
	{
		new Thread (Go).Start();
	}
	catch (Exception ex)
	{
		// We'll never get here!
		Console.WriteLine ("Exception!");
	}
}

static void Go() { throw null; }   // Throws a NullReferenceException

//The try/catch statement in this example is ineffective, and the newly created thread will be encumbered with an unhandled NullReferenceException. 
//This behavior makes sense when you consider that each thread has an independent execution path.